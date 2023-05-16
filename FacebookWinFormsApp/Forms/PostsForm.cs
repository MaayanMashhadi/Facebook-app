using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;
using System.Windows.Forms;
using System.Collections;

namespace BasicFacebookFeatures
{
    public partial class PostsForm : Form 
    {
       private List<DemoPost> m_DemoPost;
        public List<DemoPost> demoPosts
        {
            get
            {
                return m_DemoPost;
            }
        }
        public PostsForm(List<DemoPost> i_DemoPost)
        {
            InitializeComponent();
            SingeltonUserInfo.StaticInstance.FetchUserProfile(profileNameLb, numbersOfFriendsLB, profilePB);
            m_DemoPost = i_DemoPost;
        }

        public void FetchPosts()
        {
        
            initPosts(SingeltonUserInfo.StaticInstance.LoggedInUser.Posts);
            
        }

        private void initPosts(FacebookObjectCollection<Post> i_Posts)
        {
            timeLineListB.Invoke(new Action(() =>
            {
                
                foreach (Post curPost in i_Posts)
                {
                    if (curPost.Message != null)
                    {
                        addingPostToPostsListBox(curPost.Message, curPost);
                    }
                    else if (curPost.Caption != null)
                    {
                        addingPostToPostsListBox(curPost.Caption, curPost);
                    }
                    else
                    {
                        addingPostToPostsListBox(string.Format("[{0}]", curPost.Type), curPost);
                    }
                }

                if (i_Posts.Count == 0 && m_DemoPost == null)
                {
                    timeLineListB.Items.Add("No posts for this user");
                }
                else
                {
                    addAllRandomFactsPosts(m_DemoPost);
                }

                FetchingPostsLB.Visible = false;
            }
            )
            );


        }

        private void postingRandomFacts(Post i_Post)
        {
            int returnVal;

            foreach(DemoPost curDemoPost in m_DemoPost)
            {
                returnVal = DemoPostToPublishcs.WhatWasEarlier(i_Post.CreatedTime, curDemoPost.TimeOfThePost);
                if(returnVal < 0 && !curDemoPost.Posted)
                {
                    timeLineListB.Items.Add(curDemoPost.Messege);
                    curDemoPost.Posted = true;
                }
            }
        }

        private void addAllRandomFactsPosts(List<DemoPost> i_DemoPosts)
        {
            if (i_DemoPosts != null)
            {
                foreach (DemoPost curDemoPost in i_DemoPosts)
                {
                    timeLineListB.Items.Add(curDemoPost.Messege);
                }
            }
            
        }

        private void addingPostToPostsListBox(string i_PostString, Post i_Post)
        {
            if(m_DemoPost != null)
            {
                postingRandomFacts(i_Post);
            }

            timeLineListB.Items.Add(i_PostString);
        }

        private void timeLineListB_MeasureItem(object i_Sender, MeasureItemEventArgs i_e)
        {
            i_e.ItemHeight = 13 * getLinesNumber((string)timeLineListB.Items[i_e.Index]);
        }
       
        private void timeLineListB_DrawItem(object i_Sender, DrawItemEventArgs i_e)
        {
            i_e.DrawBackground();
            i_e.Graphics.DrawString(timeLineListB.Items[i_e.Index].ToString(), i_e.Font, new SolidBrush(i_e.ForeColor), i_e.Bounds);
        }

        private int getLinesNumber(string i_Text)
        {
            return i_Text.Split('\n').Length;
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            FetchingPostsLB.ForeColor = Colores.PrimeryColor;
            FetchingPostsLB.Visible = true;
            new Thread(FetchPosts).Start();
        }

    }
}
