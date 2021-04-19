using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroPOO1LAB
{
    public abstract class Transporte
    {
        public int cantPasajeros;
        public string nombre;
        public int cantPasajerosMax { get;  protected set; }

        public Transporte(string nombre, int cantPasajeros)
        {
            this.nombre = nombre;
            this.cantPasajeros = cantPasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        public void SubirPasajero(int cant)
        {
            if((cantPasajeros + cant) > cantPasajerosMax)
            {
                Console.WriteLine($"No se pueden subir {cant} pasajeros ya que sobrepasa la capacidad maxima del {this.nombre}.");
            } else
            {
                cantPasajeros = cantPasajeros + cant;
                Console.WriteLine($"{cant} se subieron al {this.nombre}");
            }
        }

        public void BajarPasajero(int cant)
        {
            if ((cantPasajeros - cant) < 0)
            {
                Console.WriteLine($"No se pueden bajar {cant} pasajeros ya que solo hay {this.cantPasajeros} pasajero en el {this.nombre}.");
            }
            else
            {
                cantPasajeros = cantPasajeros - cant;
                Console.WriteLine($"{cant} se bajaron del {this.nombre}");
            }
        }
    }
}
