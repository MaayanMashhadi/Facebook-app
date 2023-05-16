using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Chain_of_Responsibility
{
    public abstract class Handler
    {
        public Handler successor { get; set; }
        public abstract void HandleRequest(Request i_Request);
    }
}
