using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Dectrotors
{
    internal class MidFielder : PlayerRole
    {
        public override string PassBall()
        {
            return "MidFielder " + _player.PassBall();
        }
        public void Dripple()
        {
            Console.WriteLine("Drippling ball");
        }
    }
}
