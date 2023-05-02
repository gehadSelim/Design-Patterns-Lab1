using DecoratorDP;
using DecoratorDP.Dectrotors;
using DecoratorDP.Players;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player= new FieldPlayer();
            Console.WriteLine(player.PassBall()); 
            Console.WriteLine("Change Player Role to Defender: ");
            PlayerRole role =  new Defender();
            role.AssignPlayer(player);
            player = role;
            Console.WriteLine(player.PassBall());
            role = new Forward();
            role.AssignPlayer(player);
            player = role;
            Console.WriteLine(player.PassBall());


        }
    }
}