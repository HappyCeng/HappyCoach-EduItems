using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Monkey : Animal
    {

        private string animalName;
        private string animalType;

        public Monkey() 
        {

        }

        public Monkey(string animalName, string animalType)
        {
            this.animalName = animalName;
            this.animalType = animalType;
        }

    }
}
