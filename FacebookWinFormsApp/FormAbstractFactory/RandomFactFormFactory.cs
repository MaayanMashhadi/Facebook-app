﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;

namespace BasicFacebookFeatures.FormAbstractFactory
{
    public class RandomFactFormFactory : IFormFactory
    {
        public Form CreateForm(FormMain i_FormMain)
        {
            return new RandomFacts(i_FormMain);
        }
    }
}
