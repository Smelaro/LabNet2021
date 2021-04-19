using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroExtensionMethodsLAB
{
    class Punto2
    {
        public static void Ejercicio2()
        {
            try
            {
                Console.WriteLine("Ingrese 2 numeros para realizar la division.");
                Console.Write("Ingrese el primer valor (dividendo): ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo valor (divisor): ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int resultado = numero1 / numero2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Solo Chuck Norris puede dividir por cero.");
                Console.WriteLine(e.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada.");
                Console.WriteLine(f.Message);
            }
            Console.ReadKey();
        }
    }
}
