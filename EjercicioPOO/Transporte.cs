using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public abstract class Transporte
    {
        private int cantPasajeros;
        public int CantPasajeros
        {
            get { return cantPasajeros; }
            set { this.cantPasajeros = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public Transporte(string nombre, int cantPasajeros)
        {
            this.CantPasajeros = cantPasajeros;
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} pasajeros.", this.Nombre, this.CantPasajeros); ;
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
