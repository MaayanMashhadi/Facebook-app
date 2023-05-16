using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.strategy
{
    public interface IComperer
    {
        bool Comper(long? i_Item1, long? i_Item2);
    }
}
