using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Donkey : Animal
    {
        public override void soundAnimal()
        {
            Console.WriteLine("Aiiii Aiiiiiii");
        }

        public override void setAnimal()
        {
            animal_name = "Arkadaşım Eşşek";
            type = "Balıkesir";
            price = 1000;
        }

        public void setAnimalName(string AnimalName) 
        {
            animal_name = AnimalName;
        }
        public void setType(string Type)
        {
            type = Type;
        }
        public void setPrice(int Price)
        {
            price = Price;
        }

        public string getAnimalName() 
        {
            return animal_name;
        }
        public string getType() 
        {
            return type;
        }
        public int getPrice()
        {
            if(price > 500) 
            { 
                return price;
            }
            return -1;
        }

    }
}
