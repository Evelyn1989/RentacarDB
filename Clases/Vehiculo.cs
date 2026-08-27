using System;

namespace RentacarDB.Modelos
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
        public int IdSucursal { get; set; }
        public string TipoVehiculo { get; set; }
        public string Motor { get; set; }
        public string Combustible { get; set; }
        public string Transmision { get; set; }
        public int NumeroPasajeros { get; set; }
        public int NumeroMaletas { get; set; }
        public string Autonomia { get; set; }    
        public decimal Calificacion { get; set; }
        public decimal PrecioPorDia { get; set; }
        public string Foto { get; set; }

        public Vehiculo() { }

        public Vehiculo(int idVehiculo, string placa, string marca, string modelo, int anio,
                         decimal kilometraje, string estado, int idCategoria, int idSucursal,
                         string tipoVehiculo, string motor, string combustible, string transmision,
                         int numeroPasajeros, int numeroMaletas, string autonomia,
                         decimal calificacion, decimal precioPorDia, string foto)
        {
            IdVehiculo = idVehiculo;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Kilometraje = kilometraje;
            Estado = estado;
            IdCategoria = idCategoria;
            IdSucursal = idSucursal;
            TipoVehiculo = tipoVehiculo;
            Motor = motor;
            Combustible = combustible;
            Transmision = transmision;
            NumeroPasajeros = numeroPasajeros;
            NumeroMaletas = numeroMaletas;
            Autonomia = autonomia;
            Calificacion = calificacion;
            PrecioPorDia = precioPorDia;
            Foto = foto;
        }
    }
}