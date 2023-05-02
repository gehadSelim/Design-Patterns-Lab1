namespace StrategyDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            team.PlayGame();
            Console.WriteLine("changing from defend to Attack");
            team.SetStrategy(new AttackStrategy());
            team.PlayGame();
        }
    }
}