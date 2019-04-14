using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactryLib.ProductLibrary
{
    public class Lion : Carnivore
    {
        public override void Eats(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name+"Eats "+ herbivore.GetType().Name);
        }
    }
}
