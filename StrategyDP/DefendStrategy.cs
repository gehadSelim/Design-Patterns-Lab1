using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class DefendStrategy : TeamStrategy
    {
        public void Play()
        {
            Console.WriteLine("Defend");
        }
    }
}
