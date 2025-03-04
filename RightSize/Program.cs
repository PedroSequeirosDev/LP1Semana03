using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length < 3)
                {

                }

                else if(s.Length > 3 && s.Length <= 7)
                {
                    Console.WriteLine(s);
                }

                else if(s.Length >= 8 )
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                

            }
        }
    }
}
