namespace RentacarDB.Modelos
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }

        public Sucursal() { }

        public Sucursal(int idSucursal, string nombreSucursal, string provincia, string canton,
                         string distrito, string direccion, string telefono, string correo, bool estado)
        {
            IdSucursal = idSucursal;
            NombreSucursal = nombreSucursal;
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
        }
    }
}