using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Clases
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Kilometraje { get; set; }
        public string Estado { get; set; }
        public int IdCategoria { get; set; }
        public decimal CostoDiario { get; set; }
    }
}