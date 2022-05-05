Create database TecnoService

use TecnoService;

Create table Clientes
(
	Clt_Id int not null unique identity (1,1),
	Clt_Nombre varchar(50) not null unique,
	Clt_Ap_Paterno varchar(120) not null unique,
	Clt_Ap_Materno varchar(120) not null unique,
	Clt_Telefono tinyint not null unique,
	Clt_Dispositivo varchar(100) not null,
	Primary Key (Clt_Id)
);

Create table Dispositivo
(
	Ds_Id int not null unique identity (1,1),
	Clt_Id int not null,
	Ds_Marca varchar (50) not null,
	Ds_Modelo varchar(50) not null,
	Ds_Problema varchar(200) not null,
	Primary Key (Ds_Id),
	Foreign Key (Clt_Id) References Clientes(Clt_Id)
);

Create table Proveedores
(
	Prv_Id int not null unique identity(1,1),
	Prv_Proveedor varchar (70) not null unique, -- Empresa proveedora
	Prv_Nombre_Encargado varchar (200) not null, -- Nombre Completo del contacto con la empresa proveedora
	Prv_Telefono varchar (13) not null, --Suponiendo que sea necesario los +52 o lada de otra nación
	Prv_Direccion varchar (100) not null, -- Dirección de la empresa proveedora o el proveedor
	Primary key (Prv_Id)
);

Create Table Detalles_Compra
(
	DetCom_Id int not null unique identity(1,1),
	PrSv_Id int not null, --/// Posiblemente quede para registrar por id al producto adquirido
	Prv_Id int not null, -- Id del proveedor registrado al cual se le compro el producto,
	DetCom_Producto varchar (100) not null, --Nuevo Producto adquirido
	DetCom_Unidades int not null, --Unidades del producto adquirido
	DetCom_PrecioUnidad varchar (10) not null, -- Precio del producto adquirido con centavos
	DetCom_Fecha datetime not null,
	Primary Key (DetCom_id),
	Foreign Key (Prv_Id) References Proveedores (Prv_Id)
);

Create table Compras
(
	Com_Id int not null unique identity(1,1),
	DetCom_Id int not null,
	Com_Total varchar(10) not null,
	Primary key (Com_Id),
	Foreign Key (DetCom_Id) References Detalles_Compra (DetCom_ID)
);

Create table Producto_Servicio
(
	PrSv_Id int not null unique identity(1,1),
	Com_Id int not null,
	PrSv_Tipo tinyint not null, -- 1=Reparación de equipo 2=Venta de producto
	PrSv_Precio int not null, -- Costo del Servicio o Producto
	PrSv_Descripcion varchar (150) not null, --Descripción detallada del producto o servicio
	Primary key (PrSv_Id)
);

Create table Tecnicos
(
	Tc_Id int not null unique identity(1,1),
	Tc_Nombre varchar(50) not null unique,
	Tc_Ap_Paterno varchar(120) not null unique,
	Tc_Ap_Materno varchar(120) not null unique,
	Tc_Telefono tinyint not null,
	Tc_Nivel tinyint not null, /* 1-Admin 2-Tecnico 3-Vendedor*/
	Primary Key (Tc_Id)
);
/*Solo Admin puede Ingresar, Buscar o Eliminar Tecnicos, Clientes, Proveedores y Vendedores,
los Tecnicos y Vendedores no pueden hacer otros movivmientos que no sean Servicios, Ventas
o Registro y busqueda de Clientes, Proveedores o Productos*/

Create table Adelanto
(
	Adl_Id int not null unique identity(1,1),
	PrSv_Id int not null, --Producto o servicio al cual se le aplica el abono o adelanto
	Clt_id int not null,	
	Adl_Monto int not null,
	Primary Key (Adl_Id),
	Foreign key (PrSv_Id) references Producto_Servicio(PrSv_Id)
);

Create Table Detalles_Venta
(
	DetVet_Id int not null unique identity(1,1),
	PrSv_Id int not null,
	Tc_Id int not null, -- Para saber que Tecnico o Vendedor realizo la venta
	DetVet_Unidades int not null,
	DetVet_PrecioUnidad varchar(10) not null,
	DetVet_Fecha datetime not null, --Fecha en que se realizo la venta
	Primary key (DetVet_Id),
	Foreign key (PrSv_Id) references Producto_Servicio(PrSv_Id),
	Foreign key (Tc_Id) references Tecnicos(Tc_Id)
);

Create Table Ventas
(
	Vt_Id int not null unique identity(1,1),
	DetVet_Id int not null,
	Clt_Id int not null,
	Vt_total varchar(10),
	Primary Key (Vt_Id),
	Foreign Key (DetVet_Id) references Detalles_Venta(DetVet_Id),
	Foreign Key (Clt_Id) references Clientes (Clt_Id)
);