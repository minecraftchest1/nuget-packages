using System;
using Minecraftchest1;

namespace utils_sample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Utils.Input("Input as string: ");
            try
            {
                Utils.InputDouble("Input as double: ");
            }
            catch
            {
                Console.WriteLine("[ERROR] Input is not a double.");
            }
            string TestString="Me, You, Minecraftchest1; Minecraftchest2";
            char[] Seperators = new char[] { ',', ';'};
            Console.WriteLine($"String: {TestString}");
            Console.WriteLine($"Seperators: ',' ';'");
            foreach (var sub in StringToArray(TestString, Seperators))
            {
                Console.WriteLine("Substring: {0}", sub.Trim());
            }

            Utils.Pause();
        }
    }
}
