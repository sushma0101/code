using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace asynchronous
{
    class Program
    {
        public delegate void Fn1Caller();
       
        static void Main(string[] args)
        {
            //Myfunction2();
            //Myfunction1();
            //Fn1Caller fn1 = new Fn1Caller(Myfunction2);
            Fn1Caller fn = new Fn1Caller(Myfunction1);
            fn += CheckGaramHaiTa;
            fn += Myfunction2;
            fn();
            //fn1();
            
            Console.ReadKey();
   

        }
        public static void Myfunction1()
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Hello Sushma");
            }
        }
       public static void CheckGaramHaiTa() 
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Display vayo vaney milyooo!!!");
            }
        }
      public static async void Myfunction2()
        {
            await Task.Run(() =>
            {
            {
                for (int counter = 1; counter <= 20; counter++)
                {
                    Console.WriteLine("Sushma is fine.");

                }
            }
        });
        }

    /*{
        StreamWriter sw = new StreamWriter("Nist.txt");
        sw.WriteLine("We are learning C#.");
        sw.WriteLine("Learning file handling.");
        sw.Close();
        Console.ReadKey();
    }*/
    /* StreamReader sr = new StreamReader("Nist.txt");
     string line = sr.ReadLine();
     while (line != null)
     {
         Console.WriteLine(line);
         line = sr.ReadLine();

     }
     Console.ReadKey();
    }*/

}
}
