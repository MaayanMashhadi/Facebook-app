using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Chain_of_Responsibility
{
    public class Request
    {
        public object ARequest { get; set; }
        public string Term { get; set; }
        public FormMain MainForm { get; set; }

        public Request(object i_Sender, FormMain i_FormMain)
        {
            ARequest = i_Sender;
            Term = (i_Sender as Button).Text;
            MainForm = i_FormMain;
        }
    }
}
