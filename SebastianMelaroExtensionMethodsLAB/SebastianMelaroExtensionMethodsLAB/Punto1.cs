using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroExtensionMethodsLAB
{
    class Punto1
    {
        public static void Ejercicio1()
        {
            try
            {
                Console.Write("Ingrese un valor para realizar la division: ");
                int valorIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(valorIngresado / 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Excepcion capturada: {e.Message}");
            }
            catch (FormatException f)
            {
                Console.WriteLine($"Excepcion capturada: {f.Message}");
            }
            finally
            {
                Console.WriteLine("Termino la operacion");
            }
            Console.ReadKey();
        }
    }
}
