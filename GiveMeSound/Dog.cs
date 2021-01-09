using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Dog : Animal
    {
        public override void soundAnimal()
        {
            animal_name = "Dog2";
            Console.WriteLine("Hav Hav");
        }

        public override void setAnimal() 
        {
            animal_name = "Dog";
            type = "Kangal";
            price = 5000;
        }
    }
}
