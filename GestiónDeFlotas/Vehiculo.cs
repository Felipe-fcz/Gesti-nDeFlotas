using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónDeFlotas
{
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
    }
}
