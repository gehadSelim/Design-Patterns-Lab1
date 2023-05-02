using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Players
{
    internal class GoalKeeper : Player
    {
        public string PassBall()
        {
            return "GoalKeeper passing ball";
        }
    }
}
