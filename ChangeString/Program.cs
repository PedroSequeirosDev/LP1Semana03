using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String: ");
            string a = Console.ReadLine();
            Console.WriteLine("Caráter: ");
            string g = Console.ReadLine();

    
            string new_string = a.Replace(g,"x");

            Console.Write(new_string);
                
               

            



        
        }
    }
}
