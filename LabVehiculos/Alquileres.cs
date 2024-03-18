using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVehiculos
{
    internal class Alquileres
    {
        int nitp;
        string placa;
        DateTime fechaalq;
        DateTime fechadev;
        int km;

        public int Nitp { get => nitp; set => nitp = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fechaalq { get => fechaalq; set => fechaalq = value; }
        public DateTime Fechadev { get => fechadev; set => fechadev = value; }
        public int Km { get => km; set => km = value; }
    }
}
