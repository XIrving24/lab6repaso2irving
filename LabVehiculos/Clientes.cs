using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVehiculos
{
    internal class Clientes
    {
        int nit;
        string nombre;
        string address;

        public int Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Address { get => address; set => address = value; }
    }
}
