using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main()
        {
            int passType, num, index1, index2, index3, index4;
            char character;
            Random pass = new Random();
            
            for (int i = 0; i < 16; i++) 
            {
                passType = pass.Next(4,9);
                index1 = pass.Next(0, 4);
                index2 = pass.Next(0, 4);
                index3 = pass.Next(0, 4);
                index4 = pass.Next(0, 4);
                if (passType % 4 == index1) 
                {
                    num = pass.Next(0,10);
                    Console.Write(num.ToString());
                }
                else if (passType % 4 == index2)
                {
                    num = pass.Next(65, 91);
                    character = Convert.ToChar(num);
                    Console.Write(character.ToString());
                }
                else if (passType % 4 == index3)
                {
                    num = pass.Next(97, 122);
                    character = Convert.ToChar(num);
                    Console.Write(character.ToString());
                }
                else if (passType % 4 == index4)
                {
                    num = pass.Next(33, 47);
                    character = Convert.ToChar(num);
                    Console.Write(character.ToString());
                }
            }
            Console.WriteLine();

        }
    }
}