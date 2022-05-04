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
	Ds_Marca varchar (50) not null,
	Ds_Modelo varchar(50) not null,
	Ds_Problema varchar(200) not null,
	Clt_Id int not null,
	Primary Key (Ds_Id),
	Foreign Key (Clt_Id) References Clientes(Clt_Id)
);

Create table Tecnicos
(
	Tc_Id int not null unique identity(1,1),
	Tc_Nombre varchar(50) not null unique,
	Tc_Ap_Paterno varchar(120) not null unique,
	Tc_Ap_Materno varchar(120) not null unique,
	Tc_Telefono tinyint not null,
	Primary Key (Tc_Id)
);

Create table Adelanto
(
	Adl_Id int not null unique identity(1,1),
	Adl_Monto int not null,
	Clt_id
)