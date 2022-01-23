using System;
using System.Collections.Generic;
using System.Text;

namespace Codingame_Solutions
{
    public static class TemperatureClosestTo0
    {
        public static void ClosestTo0()
        {
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            string[] inputs = Console.ReadLine().Split(' ');
            int closestTo0 = n == 0 ? 0 : 5526;
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
                if (Math.Abs(t) < Math.Abs(closestTo0) ||
                    (Math.Abs(t) == Math.Abs(closestTo0) && t > closestTo0))
                {
                    closestTo0 = t;
                }

            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(closestTo0);
        }
    }
}
