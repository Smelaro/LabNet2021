using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroExtensionMethodsLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1.Ejercicio1();
            Punto2.Ejercicio2();
            try
            {
                Logic.Ejercicio3("Sebastian");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
            Console.ReadKey();
            try
            {
                CustomException.ThrowCustomException();
            }
            catch(CustomException ex)
            {
                Console.WriteLine($"Mensaje custom: {ex.Message}");

            }
            Console.ReadKey();
        }
    }
}
