using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroExtensionMethodsLAB
{
    public class CustomException : Exception
    {
        public CustomException() : base("Mirenme soy una Exception personalizada...")
        {
        }

        public static void ThrowCustomException()
        {
            throw new CustomException();
        }
    }
}
