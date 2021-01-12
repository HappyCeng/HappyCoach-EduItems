using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListÖdevii
{
    class Program
    {
        static void Main()
        {
            string islem = string.Empty;
            string srcstr = string.Empty;
            bool ctrl = false;
            ArrayList hmwrk = new ArrayList();

            Console.WriteLine("Welcome to ArrayList Homework \nif you are ready lets begin.!");
            do
            {
                Console.WriteLine("L: List \nF: Find \nA: Add \nD: Delete \nFR: Format List \nS: Sort List \nE: EXIT");

                islem = Console.ReadLine();
                islem = islem.ToUpper();

                switch (islem)
                {
                    case "L":
                        foreach (string i in hmwrk)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case "F":
                        Console.WriteLine("Enter what you want to search");
                        srcstr = Console.ReadLine();
                        for (int i = 0; i < hmwrk.Count; i++)
                        //foreach(string i in hmwrk)
                        {
                            if (hmwrk[i].ToString().Contains(srcstr) == true)
                            {
                                Console.WriteLine(srcstr);
                                ctrl = true;
                            }
                        }
                        if (!ctrl) 
                        {
                            Console.WriteLine("Is not an available");
                        }
                        ctrl = false;
                        break;

                    case "A":
                        Console.WriteLine("Something Enter:");
                        hmwrk.Add(Console.ReadLine());
                        break;

                    case "D":
                        Console.WriteLine("What you want delete?");
                        hmwrk.Remove(Console.ReadLine());
                        break;

                    case "FR":
                        Console.WriteLine("All index cleared.!");
                        hmwrk.Clear();
                        break;

                    case "S":
                        hmwrk.Sort();
                        foreach (string i in hmwrk)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case "E":
                        break;

                    default:
                        Console.WriteLine("Please try again..");
                        break;
                }
            } while (islem != "E");
        }
    }
}