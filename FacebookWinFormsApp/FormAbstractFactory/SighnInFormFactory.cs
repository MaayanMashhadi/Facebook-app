using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game4InARow;

namespace BasicFacebookFeatures.FormAbstractFactory
{
    public class SighnInFormFactory : IFormFactory
    {
        public Form CreateForm(FormMain i_FormMain)
        {
            return new SignInForm();
        }
    }
}
