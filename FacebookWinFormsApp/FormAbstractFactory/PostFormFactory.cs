using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;

namespace BasicFacebookFeatures.FormAbstractFactory
{
    public class PostFormFactory : IFormFactory
    {
        public Form CreateForm(FormMain i_FormMain)
        {
            if (i_FormMain.RandomFactsPostsByUser.ContainsKey(SingeltonUserInfo.StaticInstance.LoggedInUser.Name))
            {
                return new PostsForm(i_FormMain.DemoPostByUser);
            }
            else
            {
                return new PostsForm(null);
            }
        }
    }
}
