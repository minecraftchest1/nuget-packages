using System;

namespace Minecraftchest1
{
    partial class Utils
    {

        public static void Pause()
        {
            /// <summary>
            /// Waits for user.
            /// </summary>

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static string Input(string prompt)
        {
            /// <summary>
            /// Asks for user input.
            /// </summary>
            /// <param name="prompt">
            /// The message to show when asking for input.
            /// Dispalyed on the same line of the input prompt.
            /// </param>
            /// <returns>
            /// Returns the input from the user.
            /// </returns

            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public static double InputDouble(string prompt)
        {
            /// <summary>
            /// Asks for user input. Returns a double.
            /// </summary>
            /// <remarks>
            /// Returns 0 when no user input is provided.
            /// </remarks>
            /// <param name="prompt">
            /// The message to show when asking for input.
            /// Dispalyed on the same line of the input prompt.
            /// </param>
            /// <returns>
            /// Returns the input from the user.
            /// </returns>

            //Console.WriteLine("[DEBUG] Inside InputDouble");
            double inputD = 0;
            string inputS;
            inputS = Utils.Input(prompt);

            //Console.Write(prompt);
            try
            {
                inputD = Convert.ToDouble(inputS);
                //Console.WriteLine("[DEBUG] inside InputDouble try.");
            }
            catch (FormatException)
            {
                //Console.WriteLine("[DEBUG] Inside first catch.");
                if (inputS.Length == 0)
                {
                    //Console.WriteLine("[DEBUG] Inside first catch if");
                    inputD = 0;
                    return inputD;
                }
                else
                {
                    //Console.WriteLine("[DEBUG] Inside first catch else");
                    InputErrorException ex = new InputErrorException($"Could not convert {inputS} to a Double.");
                    ex.Input = inputS;
                    throw ex;
                }
            }
            catch(Exception e) 
            {
                //Console.WriteLine("[DEBUG] Inside second catch");
                throw;
            }
            //Console.WriteLine("[DEBUG] Returing from InputDouble");
            return inputD;
        }
	}
}
