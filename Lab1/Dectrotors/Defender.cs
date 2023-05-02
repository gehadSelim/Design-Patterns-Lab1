using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Dectrotors
{
    internal class Defender : PlayerRole
    {
        public override string PassBall()
        {
            return "Defender "+ _player.PassBall();
        }
        public void Defend()
        {
            Console.WriteLine("Defending");
        }
    }
}
