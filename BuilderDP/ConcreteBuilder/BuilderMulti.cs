using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.ConcreteBuilder
{
    internal class BuilderMulti : IBuilder
    {
        Product ground;
        public BuilderMulti()
        {
            ground = new Product();
        }
        public void BuildParts()
        {
            ground.Add("gallery multi");
            ground.Add("surface multi");
            ground.Add("audience multi");
        }

        public Product GetGround()
        {
            return ground;
        }
    }
}
