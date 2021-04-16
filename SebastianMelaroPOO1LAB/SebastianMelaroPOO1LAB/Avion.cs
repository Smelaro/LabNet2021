using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastianMelaroPOO1LAB
{
    public class Avion : Transporte
    {
        public Avion (string nombre, int cantPasajeros) : base(nombre, cantPasajeros)
        {
            cantPasajerosMax = 100;
        }

        public override string Avanzar()
        {
            return $"El {this.nombre} empezo a avanzar.";
        }

        public override string Detenerse()
        {
            return $"El {this.nombre} se esta deteniendo.";
        }

        protected string Despegar()
        {
            return $"El {this.nombre} empezo a despegar.";
        }

        protected string Aterrizar()
        {
            return $"El {this.nombre} empezo a aterrizar.";
        }
    }
}
