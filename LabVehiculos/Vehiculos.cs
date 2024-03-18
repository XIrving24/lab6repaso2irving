using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LabVehiculos
{
    internal class Vehiculos
    {
        string placa;
        string marca;
        string modelo;
        string color;
        decimal precio;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
