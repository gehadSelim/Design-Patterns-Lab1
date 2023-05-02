namespace BuilderDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder groundBuilderSingle = new BuilderSingle();
            IBuilder groundBuilderMulti = new BuilderMulti();

            director.ConstructGround(groundBuilderSingle);
            Product groundsingle = groundBuilderSingle.GetGround();
            Console.WriteLine($"Single {groundsingle.Display()}");

            director.ConstructGround(groundBuilderMulti);
            Product groundmulti = groundBuilderMulti.GetGround();
            Console.WriteLine($"Multi {groundmulti.Display()}");

        }
    }
}