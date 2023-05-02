using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    internal interface IBuilder
    {
        void BuildParts();
        Product GetGround();
    }
}
