using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.FormAbstractFactory;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Chain_of_Responsibility
{
    public class PostsHandler : Handler
    {
        public override void HandleRequest(Request i_Request)
        {
            if (i_Request.Term.Equals("Posts"))
            {
                i_Request.MainForm.OpenSubComponnent(new GeneralForm
                                  (new PostFormFactory(), i_Request.MainForm).Create(), i_Request.ARequest);
            }

            else if (successor != null)
            {
                successor.HandleRequest(i_Request);
            }
        }
    }
}
