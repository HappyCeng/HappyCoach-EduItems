using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Cat : Animal
    {

        private string _color;

        public string color 
        {
            get
            {
                if(_color == string.Empty)
                {
                    return "Herhangi bir renk girilmedi.";
                }
                else 
                {
                    return _color;
                }
            }
            set
            {
                _color = value.ToUpper();
            }
        }
        
        public Cat()
        {
            animal_name = "Cat";
            type = "Van";
            price = 1000;
            _color = string.Empty;
        }

        public override void soundAnimal()
        {
            Console.WriteLine("Miyav");
        }


    }
}
