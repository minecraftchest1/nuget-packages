using System;
using System.Text;

namespace Minecraftchest1
{
    public partial class Utils
    {

		static void Seperator(int length = 24, char character = '-')
        {
            StringBuilder seperator = new StringBuilder();
            //string seperator;
            for (int x = 0; x < length; x++)
                seperator.Append(character);
            Console.WriteLine(seperator.ToString());
        }

        public static void Pause(string Message = "Press any key to continue..." ,bool Seperator = false)
        {
            /// <summary>
            /// Waits for user.
            /// </summary>
			/// <param name="message">
			/// Optional message to print instead
			/// of "Press any key to continue...".
			/// </param>
			/// <param name="Seperator">
			/// Wether to print a seperator before
			/// pause message.
			/// </param>

			string _seperator = "-----------------------";

			if (Seperator == true)
			{
				Console.WriteLine(_seperator);
			}

            //Console.WriteLine("Press any key to continue...");
			Console.WriteLine(Message);
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
            /// </returns>

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
            catch(Exception) 
            {
                //Console.WriteLine("[DEBUG] Inside second catch");
                throw;
            }
            //Console.WriteLine("[DEBUG] Returing from InputDouble");
            return inputD;
        }
        static string[] StringToArray(string Input, char[] Seperators)
        {
            string[] Out = Input.Split(Seperators);
            return Out;       
        }
        static string ArrayToString(string[] Input, char Seperator)
        {
            string _output = null;
            foreach (var _item in Input)
            {
                string _a;
                _a = _item;
                
                _output = _item+Seperator;
            }

            return _output;
        }
    }
}
