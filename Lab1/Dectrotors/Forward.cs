using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Dectrotors
{
    internal class Forward : PlayerRole
    {
        public override string PassBall()
        {
            return "Forward " + _player.PassBall();
        }
        public void SootGoal()
        {
            Console.WriteLine("Shooting goal");
        }
    }
}
