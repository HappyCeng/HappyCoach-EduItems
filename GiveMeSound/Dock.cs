using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Dock : Animal
    {
        public Dock()
        {
            animal_name = "Duffy Duck";
            type = "Disney";
            price = 99999;
        }

        public override void soundAnimal() 
        {
            Console.WriteLine("Vak vaaak");
        }

        public int buy_Duck(int many)
        {
            return price * many;
        }
    }
}
