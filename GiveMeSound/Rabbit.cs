using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSound
{
    class Rabbit : Animal
    {
        public RabbitType rabbitType { get; set; }
    }

    public enum RabbitType 
    {
        Siyah = 1,
        Beyaz = 2,
        Karisik = 3,
        Seksek = 4
    }

    
}
