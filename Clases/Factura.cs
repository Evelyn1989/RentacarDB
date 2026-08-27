using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdReserva { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoPago { get; set; }
        public int DiasReserva { get; set; }
        public string NumeroVoucher { get; set; }
        public decimal TotalServiciosAdicionales { get; set; }

        public Factura() { }

        public Factura(int idFactura, int idReserva, DateTime fechaEmision, decimal subtotal,
                        decimal impuesto, decimal total, string metodoPago, string estadoPago,
                        int diasReserva, string numeroVoucher, decimal totalServiciosAdicionales)
        {
            IdFactura = idFactura;
            IdReserva = idReserva;
            FechaEmision = fechaEmision;
            Subtotal = subtotal;
            Impuesto = impuesto;
            Total = total;
            MetodoPago = metodoPago;
            EstadoPago = estadoPago;
            DiasReserva = diasReserva;
            NumeroVoucher = numeroVoucher;
            TotalServiciosAdicionales = totalServiciosAdicionales;
        }

        public decimal CalcularTotal()
        {
            Total = Subtotal + Impuesto + TotalServiciosAdicionales;
            return Total;
        }
    }
}