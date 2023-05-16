using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class DemoPost
    {
        private string m_Messege;
        private DateTime? m_TimeOfThePost;
        private bool m_Posted;

        public DemoPost(string i_Messege, DateTime? i_TimeOfThePost)
        {
            m_Messege = i_Messege;
            m_TimeOfThePost = i_TimeOfThePost;
        }

        public string Messege
        {
            get
            {
                return m_Messege;
            }

            set
            {
                m_Messege = value;
            }

        }
        public DateTime? TimeOfThePost
        {
            get
            {
                return m_TimeOfThePost;
            }

            set
            {
                m_TimeOfThePost = value;
            }

        }
        public bool Posted
        {
            get
            {
                return m_Posted;
            }

            set
            {
                m_Posted = value;
            }

        }

        public static void SavePost(string i_Messege, Dictionary<string, List<DemoPost>> i_DemoPostsByUser, string i_UserName)
        {
            DemoPost post = new DemoPost(i_Messege, DateTime.Now);

            if(i_DemoPostsByUser.ContainsKey(i_UserName))
            {
                i_DemoPostsByUser[i_UserName].Add(post);
            }
            else
            {
                List<DemoPost> listOfPosts = new List<DemoPost>();

                listOfPosts.Add(post);
                i_DemoPostsByUser.Add(i_UserName, listOfPosts);
            }
        }
    }
}
