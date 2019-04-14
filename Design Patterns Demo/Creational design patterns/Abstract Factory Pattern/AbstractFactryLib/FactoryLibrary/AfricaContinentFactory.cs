using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactryLib.ProductLibrary;

namespace AbstractFactryLib.FactoryLibrary
{
    public class AfricaContinentFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Sheep();
        }
    }
}
