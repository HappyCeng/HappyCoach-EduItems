using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Animal
    {
        public string animal_name { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        
        public virtual void soundAnimal()
        {
            //public her yerden çağırılabilir
            Console.WriteLine("Animal Sound");
        }

        private void soundAnimal2()
        {
            //sadece class içerisnde kullanılabilir.
            Console.WriteLine("Animal Sound");
        }

        protected void soundAnimal3()
        {
            //Protected sınıfın inheritance olduğu sınıflarla da kullanılabilir.
            Console.WriteLine("Animal Sound");
        }

        public virtual void setAnimal() { }

    }
}
