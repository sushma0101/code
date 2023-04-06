using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class polymorphism
    {
        public void whoami()
        {
            Console.WriteLine("I am empty function.");

        }
        public void whoami(string name, int phno)
        {
            Console.WriteLine("I am " + name + "and my ph no is " + phno);
            Console.WriteLine("\n");

        }
        public void whoami(int rollnum)
        {
            Console.WriteLine("My roll num is " + rollnum);
            Console.WriteLine("\n");
        }
        
    }

    abstract class animal
    {
        public abstract void whatieat();
        public void whatibreathe()
        {
            Console.WriteLine("I breathe oxygen.");
        }
    }
    class Tiger : animal
    {
        public override void whatieat()
        {
            Console.WriteLine("I eat animals.");

        }
    }
    public interface aarkoanimal
    {
         void whatieat();
        void whatibreathe();
    }
    class Lion : aarkoanimal
    {
        public void whatieat()
        {
            Console.WriteLine("I eat animalssssss.");
        }
        public void whatibreathe()
        {
        Console.WriteLine("I breathe oxygennnn.");
            }

    }
}
