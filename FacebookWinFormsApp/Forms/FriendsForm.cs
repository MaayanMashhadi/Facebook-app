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

namespace BasicFacebookFeatures.Forms
{
    public partial class FriendsForm : Form
    {
        public FriendsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_e)
        {
            base.OnShown(i_e);
            SingeltonUserInfo.StaticInstance.FetchUserProfile(profileNameLB, numberOfFriendsLB, profilePB);
            SingeltonUserInfo.StaticInstance.FetchFriendsList(friendsListB);

        }
    }
}
