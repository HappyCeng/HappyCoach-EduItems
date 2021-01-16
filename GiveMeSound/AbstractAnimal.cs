using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    public abstract class AbstractAnimal
    {
        public string animalNameAbs { get; set; }

        public abstract void soundAnimalAbs();

        public void newMethod()
        {
            Console.WriteLine();
        }

    }
}
