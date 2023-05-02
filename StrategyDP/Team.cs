using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    internal class Team
    {
        public TeamStrategy _strategy { get; set; } = new DefendStrategy();
        public void SetStrategy(TeamStrategy strategy)
        {
            _strategy = strategy;
        }
        public void PlayGame()
        {
            _strategy.Play();
        }
    }
}
