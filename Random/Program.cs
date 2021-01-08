using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main()
        {
            Random randomNumber = new Random();
            int num = randomNumber.Next(); // random number

            num = randomNumber.Next(50);

            num = randomNumber.Next(98, 102);

            Console.WriteLine(num.ToString());

            int ascii = randomNumber.Next(65, 91); // random character
            char character = Convert.ToChar(ascii);

            Console.WriteLine(character.ToString());
        }
    }
}