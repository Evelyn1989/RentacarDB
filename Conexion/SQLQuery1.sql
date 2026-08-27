CREATE TABLE TipoIdentificacion(
    IdTipoIdentificacion INT IDENTITY(1,1) PRIMARY KEY,
    NombreTipo VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(150)
);
GO

CREATE TABLE Perfil(
    IdPerfil INT IDENTITY(1,1) PRIMARY KEY,
    NombrePerfil VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(150),
    Estado VARCHAR(20)
);
GO

CREATE TABLE Usuario(
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(20) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(100) NOT NULL,
    Correo VARCHAR(100),
    Estado VARCHAR(20),
    IdPerfil INT NOT NULL,

    CONSTRAINT FK_Usuario_Perfil
    FOREIGN KEY(IdPerfil)
    REFERENCES Perfil(IdPerfil)
);
GO

CREATE TABLE Sucursal(
    IdSucursal INT IDENTITY(1,1) PRIMARY KEY,
    NombreSucursal VARCHAR(100),
    Provincia VARCHAR(50),
    Canton VARCHAR(50),
    Distrito VARCHAR(50),
    Direccion VARCHAR(200),
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    Estado VARCHAR(20)
);
GO

CREATE TABLE CategoriaVehiculo(
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    NombreCategoria VARCHAR(50),
    Descripcion VARCHAR(200)
);
GO

CREATE TABLE Cliente(
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(20) NOT NULL,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    SegundoApellido VARCHAR(50),
    FechaNacimiento DATE,
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    NumeroLicencia VARCHAR(30),
    FechaVencLicencia DATE,
    IdTipoIdentificacion INT,
    Sexo VARCHAR(20),
    FechaVencDocumento DATE,
    Pais VARCHAR(50),
    Provincia VARCHAR(50),
    Canton VARCHAR(50),
    Distrito VARCHAR(50),
    Direccion VARCHAR(200),

    CONSTRAINT FK_Cliente_TipoIdentificacion
    FOREIGN KEY(IdTipoIdentificacion)
    REFERENCES TipoIdentificacion(IdTipoIdentificacion)
);
GO

CREATE TABLE Vehiculo(
    IdVehiculo INT IDENTITY(1,1) PRIMARY KEY,
    Placa VARCHAR(10),
    Marca VARCHAR(50),
    Modelo VARCHAR(50),
    Anio INT,
    Color VARCHAR(50),
    Chasis VARCHAR(100),
    Motor VARCHAR(50),
    Kilometraje DECIMAL(10,2),
    Estado VARCHAR(20),
    IdCategoria INT,
    IdSucursal INT,
    TipoVehiculo VARCHAR(50),
    Combustible VARCHAR(30),
    Transmision VARCHAR(30),
    NumeroPasajeros INT,
    NumeroMaletas INT,
    Autonomia VARCHAR(50),
    Calificacion DECIMAL(3,2),
    PrecioPorDia DECIMAL(10,2),
    UltimoMantenimiento DATE,
    VencimientoRTV DATE,
    Foto VARCHAR(250),

    CONSTRAINT FK_Vehiculo_Categoria
    FOREIGN KEY(IdCategoria)
    REFERENCES CategoriaVehiculo(IdCategoria),

    CONSTRAINT FK_Vehiculo_Sucursal
    FOREIGN KEY(IdSucursal)
    REFERENCES Sucursal(IdSucursal)
);
GO

CREATE TABLE Reserva(
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT,
    IdVehiculo INT,
    FechaReserva DATE,
    FechaInicio DATE,
    FechaFin DATE,
    HoraInicio TIME,
    HoraFin TIME,
    Estado VARCHAR(20),
    IdSucursalRetiro INT,
    IdSucursalDevolucion INT,

    CONSTRAINT FK_Reserva_Cliente
    FOREIGN KEY(IdCliente)
    REFERENCES Cliente(IdCliente),

    CONSTRAINT FK_Reserva_Vehiculo
    FOREIGN KEY(IdVehiculo)
    REFERENCES Vehiculo(IdVehiculo),

    CONSTRAINT FK_Reserva_SucursalRetiro
    FOREIGN KEY(IdSucursalRetiro)
    REFERENCES Sucursal(IdSucursal),

    CONSTRAINT FK_Reserva_SucursalDevolucion
    FOREIGN KEY(IdSucursalDevolucion)
    REFERENCES Sucursal(IdSucursal)
);
GO

CREATE TABLE ServicioAdicional(
    IdServicio INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion VARCHAR(150),
    Costo DECIMAL(10,2),
    Estado VARCHAR(20)
);
GO

CREATE TABLE Factura(
    IdFactura INT IDENTITY(1,1) PRIMARY KEY,
    IdReserva INT,
    FechaEmision DATE,
    Subtotal DECIMAL(10,2),
    Impuesto DECIMAL(10,2),
    Total DECIMAL(10,2),
    MetodoPago VARCHAR(30),
    EstadoPago VARCHAR(20),
    DiasReserva INT,
    NumeroVoucher VARCHAR(50),
    TotalServiciosAdicionales DECIMAL(10,2),

    CONSTRAINT FK_Factura_Reserva
    FOREIGN KEY(IdReserva)
    REFERENCES Reserva(IdReserva)
);
GO

CREATE TABLE DetalleFactura(
    IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
    IdFactura INT,
    IdServicio INT,
    IdVehiculo INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2),
    Costo DECIMAL(10,2),

    CONSTRAINT FK_DetalleFactura_Factura
    FOREIGN KEY(IdFactura)
    REFERENCES Factura(IdFactura),

    CONSTRAINT FK_DetalleFactura_Servicio
    FOREIGN KEY(IdServicio)
    REFERENCES ServicioAdicional(IdServicio),

    CONSTRAINT FK_DetalleFactura_Vehiculo
    FOREIGN KEY(IdVehiculo)
    REFERENCES Vehiculo(IdVehiculo)
);
GO


INSERT INTO Perfil (NombrePerfil, Descripcion, Estado) 
VALUES 
('Administrador', 'Acceso total al sistema', 'Activo'),
('Vendedor', 'Gestión de reservas y clientes', 'Activo'),
('Mantenimiento', 'Gestión de estado de vehículos', 'Activo');

INSERT INTO Sucursal (NombreSucursal, Provincia, Canton, Distrito, Direccion, Telefono, Correo, Estado)
VALUES ('Central San José', 'San José', 'San José', 'Catedral', 'Oficina Principal', '2222-0000', 'info@rentacar.com', 'Activo');

INSERT INTO CategoriaVehiculo (NombreCategoria, Descripcion)
VALUES 
('Sedán', 'Vehículos compactos y familiares'),
('SUV', 'Camionetas y 4x4'),
('Hatchback', 'Vehículos pequeños de bajo consumo');
GO