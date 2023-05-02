using ObserverDP.Observer;
using ObserverDP.Subject;

namespace ObserverDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootBall ball = new FootBall();
            Player p1 = new Player(1);
            Player p2 = new Player(2);
            Player p3 = new Player(3);
            Referee r1 = new Referee(1);

            ball.AttachObserver(p1);
            ball.AttachObserver(p2);
            ball.AttachObserver(p3);
            ball.AttachObserver(r1);

            ball.SetBallPosition(new Position(4, 5, 9));
            ball.NotifyObservers();

            Console.WriteLine("player3 detached");
            ball.DetachObserver(p3);

            ball.SetBallPosition(new Position(9, 7, 3));
            ball.NotifyObservers();

        }
    }
}