using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int? IdServicio { get; set; }
        public int? IdVehiculo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Costo { get; set; }

        public DetalleFactura() { }

        public DetalleFactura(int idDetalle, int idFactura, int? idServicio, int? idVehiculo,
                               int cantidad, decimal precioUnitario, decimal costo)
        {
            IdDetalle = idDetalle;
            IdFactura = idFactura;
            IdServicio = idServicio;
            IdVehiculo = idVehiculo;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Costo = costo;
        }


        public decimal CalcularCosto()
        {
            Costo = Cantidad * PrecioUnitario;
            return Costo;
        }
    }
}
