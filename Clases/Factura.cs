using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Clases
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdReserva { get; set; }
        public DateTime FechaFactura { get; set; }
        public int DiasReserva { get; set; }
        public string TipoPago { get; set; }
        public decimal ServicioAdicionalTotal { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
