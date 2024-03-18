using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVehiculos
{
    internal class Reporte
    {
        string nombre;
        string marca;
        string modelo;
        DateTime fechaDevo;
        decimal total;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo1 { get => modelo; set => modelo = value; }
        public DateTime FechaDevo { get => fechaDevo; set => fechaDevo = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
