using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroPOO1LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion1 = new Avion("Airbus 319", 100);
            Avion avion2 = new Avion("Boeing 737", 30);
            Avion avion3 = new Avion("Antonov 225", 10);
            Avion avion4 = new Avion("Grumman F-14", 2);
            Avion avion5 = new Avion("Douglas DC-3", 37);

            Automovil auto1 = new Automovil("Volkswagen Golf", 3);
            Automovil auto2 = new Automovil("Peugeot 205", 5);
            Automovil auto3 = new Automovil("Fiat Uno", 2);
            Automovil auto4 = new Automovil("Renault Megane", 4);
            Automovil auto5 = new Automovil("Ford Focus", 1);

            List<Transporte> transportes = new List<Transporte> {
                avion1, avion2, avion3, avion4, avion5,
                auto1, auto2, auto3, auto4, auto5
            };

            foreach(var item in transportes)
            {
                Console.WriteLine($"El {item.GetType().Name} {item.nombre} tiene {item.cantPasajeros} pasajeros a bordo.");
            }

            auto1.SubirPasajero(7);
            auto5.BajarPasajero(2);

            Console.ReadKey();
        }
    }
}
