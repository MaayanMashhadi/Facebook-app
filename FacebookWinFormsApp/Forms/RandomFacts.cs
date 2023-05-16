using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic.RandomFact;

namespace BasicFacebookFeatures.Forms
{
    public partial class RandomFacts : Form
    {
        private readonly string r_NameOfUser;
        private FormMain m_MainForm;
        public RandomFacts(FormMain i_FormMain)
        {
            InitializeComponent();
            m_MainForm = i_FormMain;
            r_NameOfUser = SingeltonUserInfo.StaticInstance.LoggedInUser.Name;
            publishLB.Visible = false;
        }

        private void randomFacts_Load(object sender, EventArgs i_e)
        {
            Colores.SetColorsToControls(this.Controls);
            GettingInfoLB.ForeColor = Colores.PrimeryColor;
        }

        private async void getFactBT_Click(object sender, EventArgs i_e)
        {
            GettingInfoLB.Visible = true;
            randomFactTB.Text = await RandomFactLogic.GetRandomFact();
            GettingInfoLB.Visible = false;
        }

        private void shareInAppBT_Click(object sender, EventArgs i_e)
        {
            DemoPost.SavePost(randomFactTB.Text, m_MainForm.RandomFactsPostsByUser, r_NameOfUser);
            publishLB.ForeColor = Colores.PrimeryColor;
            publishLB.Visible = true;
        }
    }
}
