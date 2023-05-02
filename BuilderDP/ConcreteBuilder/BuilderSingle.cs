using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.ConcreteBuilder
{
    internal class BuilderSingle : IBuilder
    {
        Product ground;
        public BuilderSingle()
        {
            ground = new Product();
        }
        public void BuildParts()
        {
            ground.Add("gallery single");
            ground.Add("surface single");
            ground.Add("audience single");
        }

        public Product GetGround()
        {
            return ground;
        }
    }
}
