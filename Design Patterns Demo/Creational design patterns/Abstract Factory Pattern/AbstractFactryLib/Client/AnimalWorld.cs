using AbstractFactryLib.FactoryLibrary;
using AbstractFactryLib.ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactryLib.Client
{
    public class AnimalWorld
    {
        Herbivore _Herbivore;
        Carnivore _Carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _Herbivore = factory.CreateHerbivore();
            _Carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _Carnivore.Eats(_Herbivore);
        }
    }
}
