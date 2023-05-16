using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public sealed class SingeltonUserInfo
    {
        private static readonly object sr_Lock = new object();
        private static SingeltonUserInfo s_StaticInstance;
        private User m_LoggedInUser;
        private SingeltonUserInfo()
        {
        }
        public static SingeltonUserInfo StaticInstance
        {
            get
            {
                if (s_StaticInstance == null)
                {
                    lock (sr_Lock)
                    {
                        if (s_StaticInstance == null)
                        {
                            s_StaticInstance = new SingeltonUserInfo();
                        }
                    }
                }

                return s_StaticInstance;
            }
        }
        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value;
            }
        }


        public void FetchFriendsList(ListBox io_ListControl)
        {
            io_ListControl.Items.Clear();
            foreach (User curFriend in m_LoggedInUser.Friends)
            {
                io_ListControl.Items.Add(curFriend);
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                io_ListControl.Items.Add("No friends here sorry...");
            }
        }

        public void FetchUserProfile(Label i_ProfileNameLb, Label i_NumberOfFriendsLB, PictureBox i_ProfilePB)
        {
            StringBuilder tempString = new StringBuilder();

            i_ProfilePB.LoadAsync(m_LoggedInUser.PictureNormalURL);
            tempString.Append("Profile name: " + m_LoggedInUser.Name);
            i_ProfileNameLb.Text = tempString.ToString();
            tempString.Clear();
            tempString.Append("Number of friends: " + m_LoggedInUser.Friends.Count);
            i_NumberOfFriendsLB.Text = tempString.ToString();
        }
    }
}
