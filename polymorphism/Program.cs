using System;
using polymorphism.com.polymorphism;
namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism!");
            check1 inherit = new inherit1();
            inherit.show();
            
            Console.ReadLine();

        }
    }
}
