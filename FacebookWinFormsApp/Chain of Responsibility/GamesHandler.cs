using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.FormAbstractFactory;
using System.Windows.Forms;
using Game4InARow;

namespace BasicFacebookFeatures.Chain_of_Responsibility
{
    public class GamesHandler : Handler
    {
        public override void HandleRequest(Request i_Request)
        {
            if (i_Request.Term.Equals("Games"))
            {
                Form sighForm = new GeneralForm(new SighnInFormFactory(), i_Request.MainForm).Create();

                i_Request.MainForm.OpenSubComponnent(sighForm, i_Request.ARequest);
                (sighForm as SignInForm).InitColors();
            }

            else if (successor != null)
            {
                successor.HandleRequest(i_Request);
            }
        }
    }
}
