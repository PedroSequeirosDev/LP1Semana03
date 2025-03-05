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

            char c =char.Parse(g);
    
            for (int i=0; i < a.Length; i++) 

            if(a[i]==c)
            {
            Console.Write("x");
            }    

            else
            {
                Console.Write(a[i]);
            }              

            



        
        }
    }
}
