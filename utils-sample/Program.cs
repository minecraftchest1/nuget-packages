using System;
using Minecraftchest1;

namespace utils_sample
{
    class Program
    {
        static string ArrayToString(string[] Input, char Seperator)
        {
            string Out;
            for (int i = 0; i < Input.Length; i++)
            {
                Out += Input[i];
            }
            return Out;
        }
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
        /*string TestString = "Me, You, Minecraftchest1; Minecraftchest2";
        char[] Seperators = new char[] { ',', ';' };
        Console.WriteLine($"String: {TestString}");
        Console.WriteLine($"Seperators: ',' ';'");
        foreach (var sub in Utils.StringToArray(TestString, Seperators))
        {
            Console.WriteLine("Substring: {0}", sub.Trim());
        }*/

        string[] TestArray = new string[]{'Hello','World'};

        Utils.Pause();
    }
}
}
