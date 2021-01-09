using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Cat : Animal
    {
        
        public Cat()
        {
            animal_name = "Cat";
            type = "Van";
            price = 1000;
        }


        
        public override void soundAnimal()
        {
            Console.WriteLine("Miyav");
        }
    }
}
