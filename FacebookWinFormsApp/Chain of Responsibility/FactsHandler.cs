using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.FormAbstractFactory;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Chain_of_Responsibility
{
    public class FactsHandler : Handler
    {
        public override void HandleRequest(Request i_Request)
        {
            if (i_Request.Term.Equals("Get random fact"))
            {
                i_Request.MainForm.OpenSubComponnent(new GeneralForm
                                  (new RandomFactFormFactory(), i_Request.MainForm).Create(), i_Request.ARequest);
            }

            else if (successor != null)
            {
                successor.HandleRequest(i_Request);
            }
        }
    }
}
