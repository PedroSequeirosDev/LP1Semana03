using System;
using System.Globalization;


namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] m = new float[2, 2];

            m[0, 0] = float.Parse(args[0], CultureInfo.InvariantCulture);
            m[0, 1] = float.Parse(args[1], CultureInfo.InvariantCulture);
            m[1, 0] = float.Parse(args[2], CultureInfo.InvariantCulture);
            m[1, 1] = float.Parse(args[3], CultureInfo.InvariantCulture);

            float[] v = new float[2];

            v[0] = float.Parse(args[4], CultureInfo.InvariantCulture);
            v[1] = float.Parse(args[5], CultureInfo.InvariantCulture);

            float[] final = new float[2];

            for (int i = 0; i < 2; i++)
            {
                final[i] = 0;

                for (int j = 0; j < 2; j++)
                {
                    final[i] += m[i, j] * v[j];
                }
            }
            foreach (float result in final)
            {
                Console.WriteLine($"| {result:f2} |");
            }



        }
    }
}
