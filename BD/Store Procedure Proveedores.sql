create procedure SP_Proveedores
@OP tinyint,
@Prov_Id int = 0,
@Prov_Ras_Soci varchar (50),
@Prov_Nom_Contac varchar (50),
@Prov_Telefono varchar(10)=null ,
@Prov_Direccion varchar(50),
@Prov_estatus char (1)

AS
begin
    if @OP = 1
		begin
			if not exists (select * from Proveedores where Prv_Id = @Prov_Id)
			begin
				insert into Proveedores(Prv_Id, Prv_Razonsocial, Prv_Nombre_Contacto, Prv_Telefono, Prv_Direccion, Prv_Estatus)
				values(@Prov_Id,@Prov_Ras_Soci,@Prov_Nom_Contac,@Prov_Telefono,@Prov_Direccion,@Prov_estatus)
			end
		end
	else
		begin
			update Proveedores set  Prv_Razonsocial=@Prov_Ras_Soci, Prv_Nombre_Contacto = @Prov_Nom_Contac, Prv_Telefono = @Prov_Telefono, Prv_Direccion = @Prov_Direccion, Prv_Estatus=@Prov_estatus
			where Prv_Id = @Prov_Id
		end
	if @OP=2
	begin
		select  Prv_Razonsocial as 'Razon Social', Prv_Nombre_Contacto as 'Nombre Del Contacto', Prv_Telefono as Telefono,  Prv_Direccion as Direccion, Prv_Estatus as Estado
		from Proveedores
		where Prv_Id = @Prov_Id
	end
	if @OP=3
	begin
		update Proveedores set  Prv_Razonsocial=@Prov_Ras_Soci, Prv_Nombre_Contacto = @Prov_Nom_Contac, Prv_Telefono = @Prov_Telefono, Prv_Direccion = @Prov_Direccion
		where Prv_Id = @Prov_Id
	end
	if @OP = 4
	begin
		select Prv_Id, Prv_Razonsocial as Razon_Social, Prv_Nombre_Contacto as Nombre_Del_Contacto, Prv_Telefono as Telefono,  Prv_Direccion as Direccion, DBO.Fn_Proveedores('A') as Estado
		from Proveedores
	end
end

alter table Proveedores
add Prv_Estatus char(1);