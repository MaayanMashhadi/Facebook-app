using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Game4InARow;
using System.Text.Json;
using BasicFacebookFeatures.FormAbstractFactory;
using BasicFacebookFeatures.Chain_of_Responsibility;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private SingeltonUserInfo m_LoggedInUser = null;
        private LoginResult m_LoginResult;
        private Random m_RandomColorIndex;
        private int m_TempIndex;
        private Button m_CurButton;
        private Form m_ActivForm;
        private FacebookManager m_FacebookManager;
        private Dictionary<string, List<DemoPost>> m_RandomFactsPostsByUser;
        private AppSettings m_AppSettings;
        private List<Handler> m_Handlers = new List<Handler> {new AlbumsHandler(), new FactsHandler(),
        new FriendsHandler(), new GamesHandler(), new PostsHandler()};

        public Dictionary<string, List<DemoPost>> DemoPosts
        {
            get
            {
                return m_RandomFactsPostsByUser;
            }
        }

        public List<DemoPost> DemoPostByUser
        {
            get
            {
                return m_RandomFactsPostsByUser[m_LoggedInUser.LoggedInUser.Name];
            }
        }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            m_RandomColorIndex = new Random();
            initVisability(false);
            m_FacebookManager = new FacebookManager();
            m_RandomFactsPostsByUser = new Dictionary<string, List<DemoPost>>();
            m_AppSettings = new AppSettings();
            InitChainOfResponsibility();
            loadAppSettings();
        }

        private void loadAppSettings()
        {
            m_AppSettings = AppSettings.LoadFromFile();
            StartPosition = FormStartPosition.Manual;
            Size = m_AppSettings.LastWindowSize;
            Location = m_AppSettings.LastWindowLocation;
            rememberMeCB.Checked = m_AppSettings.IsRememberUser;
            if(m_AppSettings.IsRememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                m_FacebookManager.AccessTokenCheck(m_LoginResult);
                m_LoggedInUser = SingeltonUserInfo.StaticInstance;
                login();
            }

        }
        public Dictionary<string, List<DemoPost>> RandomFactsPostsByUser
        {
            get
            {
                return m_RandomFactsPostsByUser;
            }
        }

        public void OpenSubComponnent(Form i_SubComponnent, object sender)
        {
            if (m_ActivForm != null)
            {
                m_ActivForm.Close();
            }

            activeButton(sender);
            m_ActivForm = i_SubComponnent;
            i_SubComponnent.TopLevel = false;
            i_SubComponnent.FormBorderStyle = FormBorderStyle.None;
            i_SubComponnent.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(i_SubComponnent);
            MainPanel.Tag = i_SubComponnent;
            i_SubComponnent.BringToFront();
            i_SubComponnent.Show();
            Button clickedButton = sender as Button;

            if (!clickedButton.Text.Equals("Login") && !clickedButton.Text.Equals("Logout"))
            {
                titleLB.Text = clickedButton.Text;
            }
        }

        private void loginBT_Click(object i_sender, EventArgs i_e)
        {
            m_FacebookManager.LoginFacebookServic(out m_LoginResult);
            m_LoggedInUser = SingeltonUserInfo.StaticInstance;
            login();
        }

        private void login()
        {
            if (m_LoggedInUser.LoggedInUser != null)
            {
                initVisability(true);
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void logoutBT_Click(object i_sender, EventArgs i_e)
        {
            FacebookService.LogoutWithUI();
            resetComponnents();
        }

        private Color selectColor()
        {
            int index = m_RandomColorIndex.Next(Colores.ColorList.Count);
            string color;

            while(m_TempIndex == index)
            {
                index = m_RandomColorIndex.Next(Colores.ColorList.Count);
            }

            m_TempIndex = index;
            color = Colores.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void activeButton(object i_sender)
        {
            Button sendeerButton = i_sender as Button;

            if(i_sender != null)
            {
                if(m_CurButton != sendeerButton)
                {
                    disableBTColors();
                    Color color = selectColor();
                    m_CurButton = sendeerButton;
                    m_CurButton.BackColor = color;
                    m_CurButton.ForeColor = Color.White;
                    m_CurButton.Font = new System.Drawing.Font(
                        "Microsoft Sans Serif",
                        11F,
                        System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point,
                        ((byte)(0)));
                    titlePanle.BackColor = color;
                    iconPanel.BackColor = Colores.ColorBrightnessChangeIconPanel(color);
                    Colores.PrimeryColor = color;
                    Colores.SeconderyColor = Colores.ColorBrightnessChangeIconPanel(color);
                }
            }
        }

        private void disableBTColors()
        {
            foreach(Control otherButtons in menuePanel.Controls)
            {
                if(otherButtons.GetType() == typeof(Button))
                {
                    otherButtons.BackColor = Color.FromArgb(51, 51, 76);
                    otherButtons.ForeColor = Color.White;
                    otherButtons.Font = new System.Drawing.Font(
                        "Microsoft Sans Serif",
                        9.5F,
                        System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point,
                        ((byte)(0)));
                }
            }
        }

       
        private void initVisability(bool i_Flag)
        {
            rememberMeCB.Visible = i_Flag;
            factBT.Visible = i_Flag;
            gamesBT.Visible = i_Flag;
            albumsBT.Visible = i_Flag;
            friendsBT.Visible = i_Flag;
            postBT.Visible = i_Flag;
            LogoutBT.Visible = i_Flag;
            welcomeLb.Visible = !i_Flag;
            LoginBT.Visible = !i_Flag;
        }

        private void resetComponnents()
        {
            m_ActivForm.Close();
            initVisability(false);
            menuePanel.BackColor = Colores.MenuePanale;
            titlePanle.BackColor = Colores.TitlePanel;
            iconPanel.BackColor = Colores.IconPanel;
            titleLB.Text = "Login profile";
        }

        protected override void OnFormClosing(FormClosingEventArgs i_e)
        {
            base.OnFormClosing(i_e);
            if(rememberMeCB.Checked)
            {
                m_AppSettings.LastWindowSize = Size;
                m_AppSettings.LastWindowLocation = Location;
                m_AppSettings.IsRememberUser = rememberMeCB.Checked;
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_AppSettings.SaveToFile();
            }
            else
            {
                m_AppSettings.DefaultSettings();
            }
        }

        private void InitChainOfResponsibility()
        {
            int i = 0;

            for(int j = 1; j < m_Handlers.Count; j++)
            {
                m_Handlers[i].successor = m_Handlers[j];
                i++;

                if((j + 1) == m_Handlers.Count)
                {
                    m_Handlers[j].successor = m_Handlers[0];
                }
            }
        }

        private void penalBT_Click(object i_Sender, EventArgs i_EventArgs)
        {
            Request request = new Request(i_Sender, this);

            m_Handlers[0].HandleRequest(request);
        }
    }
}
