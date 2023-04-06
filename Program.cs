using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            polymorphism ply = new polymorphism();
            {
                /*ply.whoami("Sushma",98499);
                  ply.whoami(01);
                  ply.whoami();
               Tiger tiger = new Tiger();
                   tiger.whatieat();
                   tiger.whatibreathe();
                   Lion lion = new Lion();
                   lion.whatieat();
                   lion.whatibreathe();
                   lion.whatibreathe();*/
                try
                {
                    string[] name = new string[2];
                    name[0] = "sushma";
                    name[5] = "shreeti";
                    string mynumber = Console.ReadLine();
                    int rollnumber = Convert.ToInt32(mynumber);
                    Console.WriteLine(rollnumber);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            Console.ReadKey();
        }
    }
}

