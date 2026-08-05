using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Clases
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string LocalidadRetiro { get; set; }
        public string LocalidadDevolucion { get; set; }
    }
}