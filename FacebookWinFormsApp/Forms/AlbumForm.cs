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
using System.Threading;
using BasicFacebookFeatures.strategy;

namespace BasicFacebookFeatures.Forms
{
    public partial class AlbumForm : Form
    {
        private IComperer Comper { get; set; }
        public AlbumForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_e)
        {
            base.OnShown(i_e);
            fetchingInfoLB.ForeColor = Colores.PrimeryColor;
            fetchingInfoLB.Visible = true;
            SingeltonUserInfo.StaticInstance.FetchUserProfile(profileNameLB, numberOfFriendsLB, profilePB);
            new Thread(initAlbums).Start();
            LoedColorToControlers();
        }

        public void LoedColorToControlers()
        {
            AlbumDetailsP.BackColor = Colores.PrimeryColor;
        }

        private void albumForm_Load(object sender, EventArgs i_e)
        {
            Colores.SetColorsToControls(this.Controls);
        }

        private void initAlbums()
        {
            var allAlbums = SingeltonUserInfo.StaticInstance.LoggedInUser.Albums;

            albumsLB.Invoke(new Action(() =>
            {
                albumsBindingSource.DataSource = allAlbums;
                fetchingInfoLB.Visible = false;
            }
            ));
        }

        private void sortUp_Click(object sender, EventArgs e)
        {

            Comper = new UpSort();
            Album[] albums;

            albums = new Album[albumsLB.Items.Count];
            int i = 0;

            foreach (Album album in albumsLB.Items)
            {
                albums[i] = album;
                i++;

            }

            MegeSort.SortMerge(albums, 0, i - 1, Comper);
            albumsBindingSource.DataSource = albums;
            
        }

        private void sortDown_Click(object sender, EventArgs e)
        {
            Comper = new DownSort();
            Album[] albums;

            albums = new Album[albumsLB.Items.Count];
            int i = 0;

            foreach (Album album in albumsLB.Items)
            {
                albums[i] = album;
                i++;
                
            }
           
            MegeSort.SortMerge(albums, 0, i - 1, Comper);
            albumsBindingSource.DataSource = albums;
        }

        private static Album[] FromListBoxToArr(ListBox i_ListBox)
        {
            Album[] albums = new Album[i_ListBox.Items.Count];
            int i = 0;

            foreach (Album album in i_ListBox.Items)
            {
                albums[i] = album;
                i++;
            }

            return albums;
        }
    }
}
