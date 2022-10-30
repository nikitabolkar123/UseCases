using System;

namespace UseCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //it will create random number between 0 and 1
            int value = random.Next(0, 2);
             if(value == 0) 
            { 
                Console.WriteLine("Employee is present");
        }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
