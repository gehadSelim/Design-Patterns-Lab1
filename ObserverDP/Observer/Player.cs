using ObserverDP.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Observer
{
    internal class Player : IObserver
    {
        Position ballPosition;
        public int Id { get; set; }
        public Player(int id)
        {
            Id = id;
        }
        public void Update(Position position)
        {
            ballPosition = position;
            Console.WriteLine($"Player{Id} :Ball Position Changed to {ballPosition}");
        }
    }
}
