using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class FirstApp
    {
        static void Main()
        {
            //tam sayilar
            byte deg1 = 255; //8 bit 0-255
            sbyte deg2 = 127; //127 arasındaki değerler -128
            short deg3 = 30000; //30binlerde eksilisi
            ushort deg4 = 60000; //shortun unsigned 
            int deg5 = 3221; //32bit
            uint deg6 = 623; //32bit unsigned hali
            long deg7 = 2321; //64bit
            ulong deg8 = 232; //64bit unsigned hile

            //Ondalık sayilar 
            float deg9 = 20.2f; //32bit 
            double deg10 = 10.2f; //64bit
            decimal deg11 = 2312; //128bit

            //String ifadeler
            char deg12 = 'A'; //Karakter alır 16 bittir.
            string deg13 = "Merhaba Dünyaaa"; //String ifadeler bu şekilde gösterilir.

            //Bool ifadeler
            bool deg14 = true; //true-false 16bit
        }
    }
}
