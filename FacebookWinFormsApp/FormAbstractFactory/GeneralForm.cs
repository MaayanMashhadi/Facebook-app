using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormAbstractFactory
{
    public class GeneralForm
    {
        private IFormFactory m_FormFactory;
        private Form m_Form;
        private FormMain m_FormMain;

        public GeneralForm(IFormFactory i_FormFactory, FormMain i_FormMain)
        {
            m_FormFactory = i_FormFactory;
            m_FormMain = i_FormMain;
        }

        public Form Create()
        {
            m_Form = m_FormFactory.CreateForm(m_FormMain);

            return m_Form;
        }
    }
}
