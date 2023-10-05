using System;

namespace firstprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine("enter first number");
            int firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int secondno = Convert.ToInt32(Console.ReadLine());
            int ans = firstno + secondno;
            Console.WriteLine($"the answer of{firstno}+{secondno}={ans}");
            Console.ReadLine();
            //Console.WriteLine(  );
           
            
        }
    }
}
