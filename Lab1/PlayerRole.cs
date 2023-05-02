using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal abstract class PlayerRole : Player
    {
        protected Player _player;
        public virtual string PassBall()
        {
            return $"{_player.PassBall()} Passing Ball";
        }

        public void AssignPlayer(Player player)
        { 
            _player= player;
        }
    }
}
