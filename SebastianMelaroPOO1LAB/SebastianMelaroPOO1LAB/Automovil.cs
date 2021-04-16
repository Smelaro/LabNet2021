using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroPOO1LAB
{
    public class Automovil : Transporte
    {
        public Automovil(string nombre, int cantPasajeros) : base(nombre, cantPasajeros)
        {
            cantPasajerosMax = 5;
        }

        public override string Avanzar()
        {
            return $"El {this.nombre} esta avanzando.";
        }

        public override string Detenerse()
        {
            return $"El {this.nombre} esta frenando.";
        }
    }
}
