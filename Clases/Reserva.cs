using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Estado { get; set; }
        public int IdSucursalRetiro { get; set; }
        public int IdSucursalDevolucion { get; set; }

        public Reserva() { }

        public Reserva(int idReserva, int idCliente, int idVehiculo, DateTime fechaReserva,
                        DateTime fechaInicio, DateTime fechaFin, TimeSpan horaInicio,
                        TimeSpan horaFin, string estado, int idSucursalRetiro, int idSucursalDevolucion)
        {
            IdReserva = idReserva;
            IdCliente = idCliente;
            IdVehiculo = idVehiculo;
            FechaReserva = fechaReserva;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Estado = estado;
            IdSucursalRetiro = idSucursalRetiro;
            IdSucursalDevolucion = idSucursalDevolucion;
        }

        public int DiasReserva => (FechaFin - FechaInicio).Days;
    }
}
