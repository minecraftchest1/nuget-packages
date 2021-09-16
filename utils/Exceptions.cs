using System;

namespace Minecraftchest1
{
    partial class Utils
    {
        [System.Serializable]
        public class InputErrorException : Exception
        {
			///<summary>
			///	Specefies that there was an error processing the input.
			///</summary>
            public InputErrorException() { }
            public InputErrorException(string message) : base(message) { }
            public InputErrorException(string message, Exception inner) : base(message, inner) { }
            protected InputErrorException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

            public string Input;
        }
    }
}
