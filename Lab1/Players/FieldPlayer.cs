using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Players
{
    internal class FieldPlayer : Player
    {
        public string PassBall()
        {
           return "FieldPlayer passing ball";
        }
    }
}
