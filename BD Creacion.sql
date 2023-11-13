-- Crea la BD
Create database Agencia_Alquiler		
go
use Agencia_Alquiler
go
SET DATEFORMAT ymd; 
go

--// Tablas
--/ Departamentos
CREATE TABLE DEPARTAMENTOS(
IdDepartamento int IDENTITY(1,1) not null,
CodDepartamento as ('DT' + RIGHT('00' + Convert(Varchar, IdDepartamento), (2))),
Nombre nvarchar(30) null,
Telefono nvarchar(12) null, 
Descripcion text null,
CONSTRAINT PkDepartamentos PRIMARY KEY(IdDepartamento)
)

Go

INSERT INTO DEPARTAMENTOS VALUES('Marketing', '809-135-2315', 'Ayuda con las estrategias de venta')
INSERT INTO DEPARTAMENTOS VALUES('Compras', '809-516-2381', 'Analiza los productos o servicios y sus tiempos de ejecucion')
INSERT INTO DEPARTAMENTOS VALUES('Recursos humanos', '809-194-2121','Gestiona los recursos humanos de la organizacion')

--/ Contactos
CREATE TABLE CONTACTOS(
IdContacto int IDENTITY(1,1) not null,
CODContacto as ('CO' + RIGHT('00' + Convert(Varchar, IdContacto), (2))),
Tipo nvarchar(15) null, /*Puede ser Concesionario, Dealer, Taller, De Calle, o Turoperador, son relaciones de negocios*/
Nombre nvarchar(30) null,
RNC nvarchar(20) null,
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Nombre_Persona nvarchar(30) null,
Cargo nvarchar(30) null,
CONSTRAINT PkContactos PRIMARY KEY(IdContacto)
)
Go

INSERT INTO CONTACTOS VALUES('Car Dealer', 'Mora Rodriguez Motors', '491234874', '5946 Main St', 'ZONA URBANA RIO TIJUANA', 'New Port Richey', 'Florida','United States','Mariah Pawns','Encargado de produccion')
INSERT INTO CONTACTOS VALUES('Taller', 'Auto soluciones Daniel', '123954234', 'Sirena market', 'Av. Independencia Capital 10014', 'Este', 'Santo Domingo', 'Republica Dominicana', 'Emilio Jow', 'Lider de calidad')

--/Presupuesto
CREATE TABLE PRESUPUESTO(
IdPresupuesto int IDENTITY(1,1),
CODPresupuesto as ('PRE' + RIGHT('00' + Convert(Varchar,IdPresupuesto), (2))),
IdDepartamento int not null,
Presupuesto int,
Nota Text,
Fecha_Actualizado datetime,
Factura nvarchar(100),
CONSTRAINT PkPresupuesto PRIMARY KEY(IdPresupuesto),
CONSTRAINT Rela_PresupuestoDepartamento FOREIGN KEY ("IdDepartamento") REFERENCES DEPARTAMENTOS(IdDepartamento)

)
Go

INSERT INTO PRESUPUESTO VALUES (1, 1500, 'Aire acondicionador', '2022-5-24 5:30:20', 'https://templates.invoicehome.com/modelo-factura-es-puro-750px.png')

--/Rol, para ser administracion, empleado o cliente
CREATE TABLE ROL(
IdRol int IDENTITY(1,1) not null,
CODRol as ('ROL' + RIGHT('00' + Convert(Varchar,IdRol), (2))),
Nombre nvarchar(30) null,
CONSTRAINT PkRol PRIMARY KEY(IdRol)
)
Go
INSERT INTO ROL VALUES('Administracion')
INSERT INTO ROL VALUES('Empleado')
INSERT INTO ROL VALUES('Cliente')

--/Usuarios
CREATE TABLE USUARIOS(
 IdUsuario int IDENTITY(1,1) not null,
 IdRol int not null,
 CODUsuario as ('US' + RIGHT('00' + Convert(Varchar, IdUsuario), (2))),
 Nombre nvarchar(50) null,
 Fecha_Creacion_Cuenta Datetime null,
 Contraseña nvarchar(20),
 Email nvarchar(20),
 Ultima_vez_ingresada Datetime null,
 On_line bit null,
 Habilitado bit null,
 CONSTRAINT PkUsuario PRIMARY KEY(IdUsuario),
 CONSTRAINT Rela_UsuarioRol FOREIGN KEY ("IdRol") REFERENCES ROL(IdRol)
 )
Go

INSERT INTO USUARIOS VALUES(1, 'Mario', '2020-4-21 9:30:20', 'Adnim13490@', 'MM@gmail.com', '2022-10-24 9:20:05', 1, 1)
INSERT INTO USUARIOS VALUES(2, 'Luigi', '2020-2-21 9:30:20', 'Logi93@_', 'LM@gmail.com', '2022-9-22 9:30:05', 1, 1)
INSERT INTO USUARIOS VALUES(3, 'Darold', '2020-4-21 9:30:20', 'Dar1994', 'Dar@gmail.com', '2022-4-24 9:20:05', 0, 1)
INSERT INTO USUARIOS VALUES(3, 'Nashyra', '2020-2-21 9:30:20', 'Nashyrap013', 'NashyraRo@gmail.com', '2022-6-22 9:30:05', 0, 1)

--/Empleados
CREATE TABLE EMPLEADOS(
IdEmpleado int IDENTITY(1,1) not null,
CODEmpleado as ('EP' + RIGHT('00' + Convert(Varchar, IdEmpleado), (2))),
IdUsuario int not null,
IdDepartamento int not null,
Cedula nvarchar(13) null,
Nombre nvarchar(50) null,
Apellido nvarchar(50) null,
Telefono nvarchar(12) null,
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Cargo nvarchar(30) null,
Contrato date null,
Fecha_nacimiento date null,
CONSTRAINT PkEmpleado PRIMARY KEY(IdEmpleado),
CONSTRAINT Rela_EmpleadoUsuario FOREIGN KEY ("IdUsuario") REFERENCES USUARIOS(IdUsuario),
CONSTRAINT Rela_EmpleadoDepartamento FOREIGN KEY ("IdDepartamento") REFERENCES DEPARTAMENTOS(IdDepartamento)
)
Go

INSERT INTO EMPLEADOS VALUES(1,1, '902-1152349-1', 'Mario', 'Mario', '809-1359-845', '2242 Foothill Boulevard', 'CENTRO', 'La Cañada Flintridge', 'California', 'United states', 'Gerente', '2021-5-3', '1988-9-15')
INSERT INTO EMPLEADOS VALUES(2,2, '912-1351363-4', 'Luigi', 'Mario', '809-1642-934', 'MIGUEL SHULTZ NO. 132,', 'SAN RAFAEL','Distrito Federal', 'Cuauhtémoc', 'Mexico', 'Director ejecutivo', '2021-2-9', '1985-3-4')

--/Clientes
CREATE TABLE CLIENTES(
IdCliente int IDENTITY(1,1) not null,
CODCliente as ('CT' + RIGHT('00' + Convert(Varchar, IdCliente), (2))),
IdUsuario int not null,
IdEmpleado_Creador int not null,
Cedula nvarchar(13) null,
Documento nvarchar(30) not null,
Documento_Num int not null,
Tarjeta_Credito nvarchar(20),
Trato nvarchar(20) null,
Nombre nvarchar(50) null,
Apellido nvarchar(50) null,
Telefono nvarchar(12) null,
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Fecha_nacimiento date null,
Foto_link nvarchar(175) null,
Tipo_Cliente nvarchar(30) null, --Empresarial, Familiar, etc
Observacion text,

CONSTRAINT PkCliente PRIMARY KEY(IdCliente),
CONSTRAINT Rela_ClienteUsuario FOREIGN KEY ("IdUsuario") REFERENCES USUARIOS(IdUsuario),
CONSTRAINT Rela_ClienteEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado)
)
Go

INSERT INTO CLIENTES VALUES(3,2,'123-4129583-9','Pasaporte', '19342', '4000 0012 3456 7899', 'Licenciado', 'Pablo', 'Paroll', '273-1943-193', 'AV. VASCO DE QUIROGA 700-E NO. 3', 'IND. AVIACION, 78140', 'San Luis Potosi', 'San Luis Potosí', 'Mexico', '1982-4-19', 'https://www.elle.com/es/living/psico/g763953/tu-rostro-habla-por-ti/',  'Empresarial', '')
INSERT INTO CLIENTES VALUES(4,1, '943-1389124-8','Carnet de Conducir', '315315', '0000 1234 5678 9010', 'Señora', 'Marte', 'Mars', '912-2359-132', 'INGENIERIA NO. 1127','MAGISTERIAL', 'Chihuahua', 'Chihuahua', 'Mexico', '1983-7-29', 'https://www.elle.com/es/living/psico/g763953/tu-rostro-habla-por-ti/','Ordinaria', '')

--/Inventario
CREATE TABLE INVENTARIO(
IdInventario int IDENTITY(1,1) not null,
CODInventario as ('INV' + RIGHT('00' + Convert(Varchar, IdInventario), (2))),
IdEmpleado_Creador int not null,
Tipo nvarchar(30) null,
Marca_Grupo_Fabricante nvarchar(40) null,
Modelo nvarchar(40) null,
Version nvarchar(40) null,
año int null,
Cantidad int null,
Costo int null,
CONSTRAINT PkInventario PRIMARY KEY(IdInventario),
CONSTRAINT Rela_InventarioEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado)
)
Go

INSERT INTO INVENTARIO VALUES(2, 'Automovil', 'KIA', 'EV6', '125 KW (170 CV) 58 kWh RWD', 2021, 50, 30000)
INSERT INTO INVENTARIO VALUES(1, 'Automovil', 'KIA', 'Sorento', '2.2 CRDi Drive DCT 4x2 7 plazas', 2020, 60, 35000) 

--/Sucursal
CREATE TABLE SUCURSAL(
	IdSucursal int IDENTITY(1,1) not null,
	CODSucursal as ('SUC' + RIGHT('00' + Convert(Varchar, IdSucursal), (2))),
	Tipo nvarchar(30) not null, --Puede ser estacionamiento o almacen
	Limite_Vehiculos int,
	Calle nvarchar(50) null,
	Sector nvarchar(50) null,
	Municipio nvarchar(50) null,
	Provincia nvarchar(50) null,
	Pais nvarchar(50) null,
	Metro_cubico int not null,
	CONSTRAINT PkSucursal PRIMARY KEY(IdSucursal)
)
Go

INSERT INTO SUCURSAL VALUES('Estacionamiento', 30,'SANTA CROCCE 204 NTE', 'SANTA CROCCE II, 37740', 'Guanajato', 'Leon', 'Mexico', 100)
INSERT INTO SUCURSAL VALUES('Almacen', 90, 'NIÑOS HEROES 186 NO. 4', 'PROGRESO, 39350', 'Guerrero', 'Acapulco', 'Mexico', 300)

--/Vehiculos
CREATE TABLE VEHICULOS(
IdVehiculo int IDENTITY(1,1) not null,
CODVehiculo as ('CR' + RIGHT('00' + Convert(Varchar, IdVehiculo), (2))),
IdInventario int not null,
IdContacto int not null, -- De quien se compro
IdSucursal int not null,
IdEmpleado_Creador int not null,
No_Chassis nvarchar(30) not null,
Fecha_Comprado datetime null,
Monto_Compra int,
Color nvarchar(30) null,
Motor nvarchar(30) null,
Millaje int null,
Transmision nvarchar(30) null,
Traccion nvarchar(30) null,
Combustion nvarchar(30) null,
CONSTRAINT PkVehiculos PRIMARY KEY(IdVehiculo),
CONSTRAINT Rela_VehiculosInventario FOREIGN KEY ("IdInventario") REFERENCES INVENTARIO(IdInventario),
CONSTRAINT Rela_VehiculosContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_VehiculosSucursal FOREIGN KEY ("IdSucursal") REFERENCES SUCURSAL(IdSucursal),
CONSTRAINT Rela_VehiculosEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado)
)
Go

INSERT INTO VEHICULOS VALUES(1, 1, 1, 2, '52WVC10338', '2021-3-4 6:30:40', 20000, 'Rojo', 'Electrico', 0, 'Manual', 'FWD', 'Inyeccion lineal')
INSERT INTO VEHICULOS VALUES(2,1,1,1, '76HCS31846', '2021-5-23 6:40:30', 25000, 'Azul', 'Gasolina', 50, 'Automatica', '4x4', 'Bomba rotativa')
INSERT INTO VEHICULOS VALUES(2,1,1,2, '18ASD39182', '2021-2-15 6:00:00', 22500, 'Amarillo', 'Diesel', 100, 'Manual', '4x4', 'EUI')
INSERT INTO VEHICULOS VALUES(1,2,1,2, '19VAR91352', '2022-7-22 4:00:00', 27500, 'Azul', 'Gasolina', 75, 'Automatica', 'RWD','Common Rail')
INSERT INTO VEHICULOS VALUES(2,2,1,2, '91ORB12345','2020-6-23 5:00:00', 27400, 'Rojo', 'Electrico', 85, 'Automatica', 'FWD', 'Common Rail')

--/Estado_Vehiculo
CREATE TABLE ESTADO_VEHICULO(
IdEstado int IDENTITY(1,1) not null,
CODEstado as ('EV' + RIGHT('00' + Convert(Varchar, IdEstado), (2))),
IdVehiculo int not null,
IdEmpleado_Creador int not null,
Nota text null,
Placa nvarchar(10) null,
Matricula nvarchar(10) null,
Combustible nvarchar(30) null,
Lubricacion nvarchar(30) null,
En_Uso bit null,
Fecha_Ultima_Revision datetime null,
Revisado_Por nvarchar(20) not null, -- Departamento de Mantenimiento o un taller externo al negocio
IdContacto int null,
CONSTRAINT PkEstado_Vehiculo PRIMARY KEY(IdEstado),
CONSTRAINT Rela_Estado_VehiculoVehiculos FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculo),
CONSTRAINT Rela_Estado_VehiculoContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_InventaroEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado)
)
Go

INSERT INTO ESTADO_VEHICULO VALUES(1, 2, '', 'SA-293', 'A472248', 'Metanol', 'Goteo', 0, '2021-5-6 16:40:30', 'Mantenimiento', null)
INSERT INTO ESTADO_VEHICULO VALUES(2,2, '', 'SAN-932', 'B824467', 'Electricidad', 'Salpicadura', 1, '2022-9-12 14:30:20', 'Contacto', 2)
INSERT INTO ESTADO_VEHICULO VALUES(3,1, '', 'FAC-1844', 'C212946', 'GLP', 'Goteo',0, '2022-9-15 14:30:00','Contacto', 2)
INSERT INTO ESTADO_VEHICULO VALUES(4,2, '', 'ACR-2903', 'D915423', 'Biodiesel','Presion', 0, '2022-4-13 15:00:00', 'Mantenimiento', null)
INSERT INTO ESTADO_VEHICULO VALUES(5, 2, '', 'SAC-891', 'E214512','Metanol', 'Salpicadura', 1, '2021-4-15 19:00:00', 'Mantenimiento', null)
GO
--/Citas
CREATE TABLE CITAS(
IdCita int IDENTITY(1,1) not null,
CODCita as ('CI' + RIGHT('00' + Convert(Varchar, IdCita), (2))),
IdCliente int not null,
IdSucursal int not null,
Kilometraje int null,
Garantia nvarchar(30) null,
Observaciones text null,
Hecho_por nvarchar(30) not null, -- El sitio web/sistema de la agencia, o un turoperador intermediario
IdEmpleado int null,
IdContacto int null,
CONSTRAINT PkCitas PRIMARY KEY (IdCita),
CONSTRAINT Rela_CitasCliente FOREIGN KEY ("IdCliente") REFERENCES CLIENTES(IdCliente),
CONSTRAINT Rela_CitasContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_CitasSucursal FOREIGN KEY ("IdSucursal") REFERENCES SUCURSAL(IdSucursal),
CONSTRAINT Rela_CitasEmpleado FOREIGN KEY ("IdEmpleado") REFERENCES EMPLEADOS(IdEmpleado)
)
Go

INSERT INTO CITAS VALUES(1,1, 500,'91A9B4', '', 'Sistema', 2, null)
INSERT INTO CITAS VALUES(1,1, 0,'8532A5', '', 'Sistema', 1, null)
INSERT INTO CITAS VALUES(2,1, 0,'41359B', '', 'Sistema', 2, null)
INSERT INTO CITAS VALUES(2,1, 300,'135AH9', '','Sistema', 2, null)

--/Factura
CREATE TABLE FACTURA(
	IdFactura int identity(1,1),
	CODFactura as ('FAC' + RIGHT('00' + Convert(Varchar, IdFactura), (2))),
	IdCita int not null,
	Nombre_Agencia nvarchar(50),
	RNC nvarchar(20),
	Fecha date,
	Total_Bruto int,
	ITEBIS int,
	Descuento int null,
	Total_General int,
	CONSTRAINT PkFactura PRIMARY KEY(IdFactura),
	CONSTRAINT Rela_FacturaCita FOREIGN KEY("IdCita") REFERENCES CITAS(IdCita)
)

INSERT INTO FACTURA VALUES(1, 'AlquilerMarco', '925985912', '2022-9-15', 600000, 18,30,312000)

--/Transaccion
CREATE TABLE TRANSACCIONES(
	IdTransaccion int identity(1,1),
	CODTransaccion as ('TRA' + RIGHT('00' + Convert(Varchar, IdTransaccion), (2))),
	IdFactura int not null,
	IdCliente int not null,
	Monto int null,
	Fecha date,
	CONSTRAINT PkTransacciones PRIMARY KEY(IdTransaccion),
	CONSTRAINT Rela_TransaccionFactura FOREIGN KEY("IdFactura") REFERENCES FACTURA(IdFactura),
	CONSTRAINT Rela_TransaccionCliente FOREIGN KEY("IdCliente") REFERENCES CLIENTES(IdCliente)
)

INSERT INTO TRANSACCIONES VALUES(1,1, 312000, '2022-9-15')

--/Fotos
CREATE TABLE FOTOS(
 IdFoto int IDENTITY(1,1) not null,
 CODFoto as ('FT' + RIGHT('00' + Convert(Varchar, IdFoto), (2))),
 IdVehiculo int not null,
 Nombre nvarchar(30) null,
 Tipo_foto nvarchar(15) null,
 Link_Imagen nvarchar(175) null,
 Fecha_Foto date null,
 CONSTRAINT PkFotos PRIMARY KEY(IdFoto),
 CONSTRAINT Rela_FotosVehiculos FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculo)
)

INSERT INTO FOTOS VALUES(1, 'Foto A1', 'Delantera', 'https://www.km77.com/images/medium/8/7/1/7/kia-ev6-2021-frontal-lateral.358717.jpg', '2021-5-9')

--/Reservas_ordenes
CREATE TABLE RESERVAS_ORDENES(
	IdCita int not null,
	IdVehiculo int not null,
	Fecha_Entrega date,
	Fecha_devolucion date,
	En_Proceso nvarchar(15) null,
	Utilidad text null,
	MetodoPago nvarchar(30) not null, --Liquido o tarjeta
	Tarifa int null,
	Total_Pag int null,
	Num_Poliza nvarchar(30) null,
	CONSTRAINT Rela_OrdenCita FOREIGN KEY ("IdCita") REFERENCES CITAS(IdCita),
	CONSTRAINT Rela_OrdenVehiculo FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculo)
)
INSERT INTO RESERVAS_ORDENES VALUES(1,1, '2022-9-15', '2022-10-1','Realizado', 'Trabajo', 'Tarjeta', 5000, 30000, '3914')
INSERT INTO RESERVAS_ORDENES VALUES(1,5, '2022-8-10', '2022-9-10', 'No Realizado', 'Tour', 'Liquido', 6000, 30000, '1352')
INSERT INTO RESERVAS_ORDENES VALUES(2,3, '2022-4-10', '2022-5-23', 'Realizado', 'Trabajo', 'Tarjeta', 5000, 30000, '1524')
INSERT INTO RESERVAS_ORDENES VALUES(2,4, '2021-3-5','2022-3-5', 'Realizado', 'Tour', 'Liquido', 4000, 30000, '2341')
INSERT INTO RESERVAS_ORDENES VALUES(3,4, '2022-4-20', '2022-5-20', 'No realizado', 'Trabajo', 'Tarjeta', 3500, 30000, '9254')
INSERT INTO RESERVAS_ORDENES VALUES(3,2, '2022-6-25', '2022-7-25', 'Realizado', 'Trabajo', 'Tarjeta', 4000, 30000, '8245')
INSERT INTO RESERVAS_ORDENES VALUES(3,2, '2022-6-25', '2022-7-25', 'Realizado', 'Trabajo', 'Tarjeta', 4000, 30000, '8245')
INSERT INTO RESERVAS_ORDENES VALUES(4,2, '2022-2-15', '2022-9-3', 'Realizado', 'Trabajo', 'Tarjeta', 3500, 30000, '9231')
INSERT INTO RESERVAS_ORDENES VALUES(4,1, '2022-9-15','2022-9-16', 'Realizado', 'Ordinario','Liquido',3500,30000, '1234')
/*
CREATE TABLE USUARIOS(
 IdUsuario int IDENTITY(1,1) not null,
 IdRol int not null,
 CODUsuario as ('US' + RIGHT('00' + Convert(Varchar, IdUsuario), (2))),
 Nombre nvarchar(50) null,
 Fecha_Creacion_Cuenta Datetime null,
 Contraseña nvarchar(20),
 Email nvarchar(20),
 Ultima_vez_ingresada Datetime null,
 On_line bit null,
 Habilitado bit null,
 CONSTRAINT PkUsuario PRIMARY KEY(IdUsuario),
 CONSTRAINT Rela_UsuarioRol FOREIGN KEY ("IdRol") REFERENCES ROL(IdRol)
 )
*/
Go
--//Procedimientos almacenados
--//Tabla Usuarios
--PROCEDURE MOSTRAR USUARIO
CREATE PROCEDURE SPMUESTRAUSUARIO
@Nombre NVARCHAR(50)
AS
SELECT * FROM USUARIOS WHERE Nombre LIKE @Nombre + '%'

Go
--PROCEDURE INSERTAR USUARIO
CREATE PROC SPINSERTAUSUARIO
 @IdRol int,
 @Nombre nvarchar(50),
 @Fecha_Creacion_Cuenta Datetime,
 @Contraseña nvarchar(20),
 @Email nvarchar(20),
 @Ultima_vez_ingresada Datetime,
 @On_line bit,
 @Habilitado bit
 AS
 INSERT INTO USUARIOS VALUES(@IdRol, @Nombre, @Fecha_Creacion_Cuenta, @Contraseña, @Email, @Ultima_vez_ingresada, @On_line, @Habilitado)

Go

--PROCEDURE EDITA USUARIO
CREATE PROC SPEDITAUSUARIO
@CODUsuario NVARCHAR(5),
@IdRol int,
 @Nombre nvarchar(50),
 @Fecha_Creacion_Cuenta Datetime,
 @Contraseña nvarchar(20),
 @Email nvarchar(20),
 @Ultima_vez_ingresada Datetime,
 @On_line bit,
 @Habilitado bit
 AS
 UPDATE USUARIOS SET IdRol = @IdRol, Nombre = @Nombre, Fecha_Creacion_Cuenta = @Fecha_Creacion_Cuenta, Contraseña = @Contraseña, Email = @Email, Ultima_Vez_ingresada = @Ultima_Vez_ingresada, On_line = @On_line, Habilitado = @Habilitado where CODUsuario = @CODUsuario

 Go

 --PROCEDURE ELIMINA USUARIO
 CREATE PROC SPELIMINAUSUARIO
 @CODUsuario NVARCHAR(5)
 AS
 DELETE USUARIOS WHERE CODUsuario = @CODUsuario

 Go
 /*CREATE TABLE DEPARTAMENTOS(
IdDepartamento int IDENTITY(1,1) not null,
CodDepartamento as ('DT' + RIGHT('00' + Convert(Varchar, IdDepartamento), (2))),
Nombre nvarchar(30) null,
Telefono nvarchar(12) null, 
Descripcion text null,
CONSTRAINT PkDepartamentos PRIMARY KEY(IdDepartamento)
)*/
 --//TABLA DEPARTAMENTOS
 --PROCEDURE MOSTRAR DEPARTAMENTO
 CREATE PROCEDURE SPMUESTRADEPARTAMENTO
@Nombre NVARCHAR(30)
AS
SELECT * FROM DEPARTAMENTOS WHERE Nombre LIKE @Nombre + '%'

Go

--PROCEDURE INSERTAR DEPARTAMENTO
CREATE PROCEDURE SPINSERTADEPARTAMENTO
@Nombre nvarchar(30),
@Telefono nvarchar(12), 
@Descripcion text
AS INSERT INTO DEPARTAMENTOS VALUES(@Nombre, @Telefono, @Descripcion)

Go

--PROCEDURE EDITAR DEPARTAMENTO
CREATE PROCEDURE SPEDITADEPARTAMENTO
@CODDepartamento NVARCHAR(5),
@Nombre nvarchar(30),
@Telefono nvarchar(12), 
@Descripcion text

AS
UPDATE DEPARTAMENTOS SET Nombre = @Nombre, Telefono = @Telefono, Descripcion = @Descripcion where CODDepartamento = @CODDepartamento

Go

--PROCEDURE ELIMINA DEPARTAMENTO
 CREATE PROC SPELIMINADEPARTAMENTO
 @CODDepartamento NVARCHAR(5)
 AS
 DELETE DEPARTAMENTOS WHERE CODDepartamento = @CODDepartamento

 Go

 /*
CREATE TABLE PRESUPUESTO(
IdPresupuesto int IDENTITY(1,1),
CODPresupuesto as ('PRE' + RIGHT('00' + Convert(Varchar,IdPresupuesto), (2))),
IdDepartamento int not null,
Presupuesto int,
Nota Text,
Fecha_Actualizado datetime,
Factura nvarchar(100),
CONSTRAINT PkPresupuesto PRIMARY KEY(IdPresupuesto),
CONSTRAINT Rela_PresupuestoDepartamento FOREIGN KEY ("IdDepartamento") REFERENCES DEPARTAMENTOS(IdDepartamento)
)
*/
--//TABLA PRESUPUESTO
 --PROCEDURE MOSTRAR PRESUPUESTO
 CREATE PROCEDURE SPMUESTRAPRESUPUESTO
@CODPresupuesto nvarchar(5)
AS
SELECT * FROM PRESUPUESTO WHERE CODPresupuesto LIKE @CODPresupuesto + '%'
Go

--PROCEDURE INSERTAR PRESUPUESTO
CREATE PROCEDURE SPINSERTAPRESUPUESTO
@IdDepartamento int,
@Presupuesto int,
@Nota Text,
@Fecha_Actualizado datetime,
@Factura nvarchar(100)
AS INSERT INTO PRESUPUESTO VALUES(@IdDepartamento, @Presupuesto, @Nota, @Fecha_Actualizado, @Factura)

Go

--PROCEDURE EDITAR PRESUPUESTO
CREATE PROCEDURE SPEDITAPRESUPUESTO
@CODPresupuesto nvarchar(5),
@IdDepartamento int,
@Presupuesto int,
@Nota Text,
@Fecha_Actualizado datetime,
@Factura nvarchar(100)

AS
UPDATE PRESUPUESTO SET IdDepartamento = @IdDepartamento, Presupuesto = @Presupuesto, Nota = @Nota, Fecha_Actualizado = @Fecha_Actualizado, Factura = @Factura where CODPresupuesto = @CODPresupuesto

Go

--PROCEDURE ELIMINA DEPARTAMENTO
 CREATE PROC SPELIMINAPRESUPUESTO
 @CODPresupuesto nvarchar(5)
 AS
 DELETE PRESUPUESTO WHERE CODPresupuesto = @CODPresupuesto

 Go

 /*
 CREATE TABLE CONTACTOS(
IdContacto int IDENTITY(1,1) not null,
CODContacto as ('CO' + RIGHT('00' + Convert(Varchar, IdContacto), (2))),
Tipo nvarchar(15) null, /*Puede ser Concesionario, Dealer, Taller, De Calle, o Turoperador, son relaciones de negocios*/
Nombre nvarchar(30) null,
RNC nvarchar(20) null,
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Nombre_Persona nvarchar(30) null,
Cargo nvarchar(30) null,
CONSTRAINT PkContactos PRIMARY KEY(IdContacto)
)
 */

 --//TABLA CONTACTOS
 --PROCEDURE MOSTRAR CONTACTO
 CREATE PROCEDURE SPMUESTRACONTACTO
@Nombre nvarchar(30)
AS
SELECT * FROM CONTACTOS WHERE Nombre LIKE @Nombre + '%'
Go

--PROCEDURE INSERTAR CONTACTO
CREATE PROCEDURE SPINSERTACONTACTO
@Tipo nvarchar(15),
@Nombre nvarchar(30),
@RNC nvarchar(20),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Nombre_Persona nvarchar(30),
@Cargo nvarchar(30)
AS INSERT INTO CONTACTOS VALUES(@Tipo, @Nombre, @RNC, @Calle, @Sector, @Municipio, @Provincia, @Pais, @Nombre_Persona, @Cargo)

Go

--PROCEDURE EDITAR CONTACTO
CREATE PROCEDURE SPEDITACONTACTO
@CODContacto nvarchar(5),
@Tipo nvarchar(15),
@Nombre nvarchar(30),
@RNC nvarchar(20),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Nombre_Persona nvarchar(30),
@Cargo nvarchar(30)
AS
UPDATE CONTACTOS SET Tipo = @Tipo, Nombre = @Nombre, RNC = @RNC, Calle = @Calle, Sector = @Sector, Municipio = @Municipio, Provincia = @Provincia, Pais = @Pais, Nombre_Persona = @Nombre_Persona, Cargo = @Cargo where CODContacto = @CODContacto

Go

--PROCEDURE ELIMINA CONTACTO
 CREATE PROC SPELIMINACONTACTO
 @CODContacto nvarchar(5)
 AS
 DELETE CONTACTOS WHERE CODContacto = @CODContacto

 Go

 /*
 CREATE TABLE EMPLEADOS(
IdEmpleado int IDENTITY(1,1) not null,
CODEmpleado as ('EP' + RIGHT('00' + Convert(Varchar, IdEmpleado), (2))),
IdUsuario int not null,
IdDepartamento int not null,
Cedula nvarchar(13) null,
Nombre nvarchar(50) null,
Apellido nvarchar(50) null,
Telefono nvarchar(12) null,	
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Cargo nvarchar(30) null,
Contrato date null,
Fecha_nacimiento date null,
CONSTRAINT PkEmpleado PRIMARY KEY(IdEmpleado),
CONSTRAINT Rela_EmpleadoUsuario FOREIGN KEY ("IdUsuario") REFERENCES USUARIOS(IdUsuario),
CONSTRAINT Rela_EmpleadoDepartamento FOREIGN KEY ("IdDepartamento") REFERENCES DEPARTAMENTOS(IdDepartamento)
)
 */
 --//TABLA EMPLEADOS
 --PROCEDURE MOSTRAR EMPLEADOS
 CREATE PROCEDURE SPMUESTRAEMPLEADOS
@Nombre nvarchar(50)
AS
SELECT * FROM EMPLEADOS WHERE Nombre LIKE @Nombre + '%'
Go

--PROCEDURE INSERTAR EMPLEADO
CREATE PROCEDURE SPINSERTAEMPLEADO
@IdUsuario int,
@IdDepartamento int,
@Cedula nvarchar(13),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(12),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Cargo nvarchar(30),
@Contrato date,
@Fecha_nacimiento date
AS INSERT INTO EMPLEADOS VALUES(@IdUsuario, @IdDepartamento, @Cedula, @Nombre, @Apellido, @Telefono, @Calle, @Sector, @Municipio, @Provincia, @Pais, @Cargo, @Contrato, @Fecha_nacimiento)

Go

--PROCEDURE EDITAR EMPLEADO
CREATE PROCEDURE SPEDITAEMPLEADO
@CODEmpleado nvarchar(5),
@IdUsuario int,
@IdDepartamento int,
@Cedula nvarchar(13),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(12),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Cargo nvarchar(30),
@Contrato date,
@Fecha_nacimiento date
AS
UPDATE EMPLEADOS SET IdUsuario = @IdUsuario, IdDepartamento = @IdDepartamento, Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Calle = @Calle, Sector = @Sector, Municipio = @Municipio, Provincia = @Provincia, Pais = @Pais, Cargo = @Cargo, Contrato = @Contrato, Fecha_nacimiento = @Fecha_nacimiento where CODEmpleado = @CODEmpleado

Go

--PROCEDURE ELIMINA EMPLEADO
 CREATE PROC SPELIMINAEMPLEADO
 @CODEmpleado nvarchar(5)
 AS
 DELETE EMPLEADOS WHERE CODEmpleado = @CODEmpleado
 Go

 /*
 CREATE TABLE CLIENTES(
IdCliente int IDENTITY(1,1) not null,
CODCliente as ('CT' + RIGHT('00' + Convert(Varchar, IdCliente), (2))),
IdUsuario int not null,
IdEmpleado_Creador int not null,
Cedula nvarchar(13) null,
Trato nvarchar(20) null,
Nombre nvarchar(50) null,
Apellido nvarchar(50) null,
Telefono nvarchar(12) null,
Calle nvarchar(50) null,
Sector nvarchar(50) null,
Municipio nvarchar(50) null,
Provincia nvarchar(50) null,
Pais nvarchar(50) null,
Fecha_nacimiento date null,
Foto_link nvarchar(50) null,
Tipo_Cliente nvarchar(30) null, --Empresarial, Familiar, etc
Observacion text,
	 nvarchar(30) not null,
Documento_Num int not null
CONSTRAINT PkCliente PRIMARY KEY(IdCliente),
CONSTRAINT Rela_ClienteUsuario FOREIGN KEY ("IdUsuario") REFERENCES USUARIOS(IdUsuario),
CONSTRAINT Rela_ClienteEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado),
)
 */

  --//TABLA CLIENTES
 --PROCEDURE MOSTRAR CLIENTES
 CREATE PROCEDURE SPMUESTRACLIENTES
@Nombre nvarchar(50)
AS
SELECT * FROM CLIENTES WHERE Nombre LIKE @Nombre + '%'
Go

--PROCEDURE INSERTAR CLIENTES
CREATE PROCEDURE SPINSERTACLIENTES
@IdUsuario int,
@IdEmpleado_Creador int,
@Cedula nvarchar(13),
@Trato nvarchar(20),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(12),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Fecha_nacimiento date,
@Foto_link nvarchar(50),
@Tipo_Cliente nvarchar(30),
@Observacion text,
@Documento nvarchar(30),
@Documento_Num int,
@Tarjeta_Credito nvarchar(20)
AS INSERT INTO CLIENTES VALUES(@IdUsuario, @IdEmpleado_Creador, @Cedula, @Documento, @Documento_Num, @Tarjeta_Credito, @Trato, @Nombre, @Apellido, @Telefono, @Calle, @Sector, @Municipio, @Provincia, @Pais, @Fecha_nacimiento, @Foto_link, @Tipo_Cliente, @Observacion)


Go

--PROCEDURE EDITAR CLIENTES
CREATE PROCEDURE SPEDITACLIENTES
@CODCliente nvarchar(5),
@IdUsuario int,
@IdEmpleado_Creador int,
@Cedula nvarchar(13),
@Trato nvarchar(20),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(12),
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Fecha_nacimiento date,
@Foto_link nvarchar(50),
@Tipo_Cliente nvarchar(30),
@Observacion text,
@Documento nvarchar(30),
@Documento_Num int,
@Tarjeta_Credito nvarchar(20)
AS
UPDATE CLIENTES SET IdUsuario = @IdUsuario, IdEmpleado_Creador = @IdEmpleado_Creador, Cedula = @Cedula,Trato = @Trato, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Calle = @Calle, Sector = @Sector, Municipio = @Municipio, Provincia = @Provincia, Pais = @Pais, Fecha_nacimiento = @Fecha_nacimiento, Foto_link = @Foto_link, Tipo_Cliente = @Tipo_Cliente, Observacion = @Observacion, Documento = @Documento, Documento_Num = @Documento_Num, Tarjeta_Credito = @Tarjeta_Credito where CODCliente = @CODCliente

Go

--PROCEDURE ELIMINA CLIENTE
 CREATE PROC SPELIMINACLIENTE
 @CODCliente nvarchar(5)
 AS
 DELETE CLIENTES WHERE CODCliente = @CODCliente

 Go

 /*
 ESTA TABLA ES DE LOS TIPOS DE VEHICULOS, CONTANDOLOS Y DICIENDO SU COSTO GENERALS
 CREATE TABLE INVENTARIO(
IdInventario int IDENTITY(1,1) not null,
CODInventario as ('INV' + RIGHT('00' + Convert(Varchar, IdInventario), (2))),
IdEmpleado_Creador int not null,
Tipo nvarchar(30) null,
Marca_Grupo_Fabricante nvarchar(40) null,
Modelo nvarchar(40) null,
Version nvarchar(40) null,
año int null,
Cantidad int null,
Costo int null,
CONSTRAINT PkInventario PRIMARY KEY(IdInventario),
CONSTRAINT Rela_InventarioEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado),
)
 */

  --//TABLA INVENTARIO
 --PROCEDURE MOSTRAR INVENTARIO
 CREATE PROCEDURE SPMUESTRAINVENTARIO
@Marca nvarchar(40)
AS
SELECT * FROM INVENTARIO WHERE Marca_Grupo_Fabricante LIKE @Marca + '%'
Go

--PROCEDURE INSERTAR INVENTARIO
CREATE PROCEDURE SPINSERTAINVENTARIO
@IdEmpleado_Creador int,
@Tipo nvarchar(30),
@Marca_Grupo_Fabricante nvarchar(40),
@Modelo nvarchar(40),
@Version nvarchar(40),
@año int,
@Cantidad int,
@Costo int
AS INSERT INTO INVENTARIO VALUES(@IdEmpleado_Creador, @Tipo, @Marca_Grupo_Fabricante, @Modelo, @Version, @Año, @Cantidad, @Costo)


Go

--PROCEDURE EDITAR INVENTARIO
CREATE PROCEDURE SPEDITAINVENTARIO
@CODInventario nvarchar(5),
@IdEmpleado_Creador int,
@Tipo nvarchar(30),
@Marca_Grupo_Fabricante nvarchar(40),
@Modelo nvarchar(40),
@Version nvarchar(40),
@año int,
@Cantidad int,
@Costo int
AS
UPDATE INVENTARIO SET IdEmpleado_Creador = @IdEmpleado_Creador, Tipo = @Tipo, Marca_Grupo_Fabricante = @Marca_Grupo_Fabricante, Modelo = @Modelo, Version = @Version, Año = @Año, Cantidad = @Cantidad, Costo = @Costo where CODInventario = @CODInventario

Go

--PROCEDURE ELIMINA INVENTARIO
 CREATE PROC SPELIMINAINVENTARIO
 @CODInventario nvarchar(5)
 AS
 DELETE INVENTARIO WHERE CODINVENTARIO = @CODINVENTARIO

 Go

 /*
 CREATE TABLE SUCURSAL(
	IdSucursal int IDENTITY(1,1) not null,
	CODSucursal as ('SUC' + RIGHT('00' + Convert(Varchar, IdSucursal), (2))),
	Tipo nvarchar(30) not null, --Puede ser estacionamiento o almacen
	Limite_Vehiculos int,
	Calle nvarchar(50) null,
	Sector nvarchar(50) null,
	Municipio nvarchar(50) null,
	Provincia nvarchar(50) null,
	Pais nvarchar(50) null,
	Metro_cubico int not null,
	CONSTRAINT PkSucursal PRIMARY KEY(IdSucursal)
)
 */

   --//TABLA SUCURSAL
 --PROCEDURE MOSTRAR SUCURSAL
 CREATE PROCEDURE SPMUESTRASUCURSAL
@Provincia nvarchar(50)
AS
SELECT * FROM SUCURSAL WHERE Provincia LIKE @Provincia + '%'
Go

--PROCEDURE INSERTAR SUCURSAL
CREATE PROCEDURE SPINSERTASUCURSAL
@Tipo nvarchar(30), 
@Limite_Vehiculos int,
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),	
@Pais nvarchar(50),	
@Metro_cubico int
AS INSERT INTO SUCURSAL VALUES(@Tipo, @Limite_Vehiculos, @Calle, @Sector, @Municipio, @Provincia, @Pais, @Metro_cubico)

Go

--PROCEDURE EDITAR SUCURSAL
CREATE PROCEDURE SPEDITASUCURSAL
@CODSucursal nvarchar(5),
@Tipo nvarchar(30), 
@Limite_Vehiculos int,
@Calle nvarchar(50),
@Sector nvarchar(50),
@Municipio nvarchar(50),
@Provincia nvarchar(50),	
@Pais nvarchar(50),	
@Metro_cubico int
AS
UPDATE SUCURSAL SET Tipo = @Tipo, Limite_Vehiculos = @Limite_Vehiculos, Calle = @Calle, Sector = @Sector, Municipio = @Municipio, Provincia = @Provincia, Pais = @Pais, Metro_cubico = @Metro_cubico where CODSucursal = @CODSucursal

Go

--PROCEDURE ELIMINA SUCURSAL
 CREATE PROC SPELIMINASUCURSAL
 @CODSucursal nvarchar(5)
 AS
 DELETE SUCURSAL WHERE CODSucursal = @CODSucursal

 Go

 /*

CREATE TABLE VEHICULOS(
IdVehiculo int IDENTITY(1,1) not null,
CODVehiculo as ('CR' + RIGHT('00' + Convert(Varchar, IdInventario), (2))),
IdInventario int not null,
IdContacto int not null, -- De quien se compro
IdSucursal int not null,
IdEmpleado_Creador int not null,
No_Chassis int not null,
Fecha_Comprado datetime null,
Monto_Compra int,
Color nvarchar(30) null,
Motor nvarchar(30) null,
Millaje nvarchar(30) null,
Transmision nvarchar(30) null,
Traccion nvarchar(30) null,
Combustion nvarchar(30) null,
CONSTRAINT PkVehiculos PRIMARY KEY(IdVehiculo),
CONSTRAINT Rela_VehiculosInventario FOREIGN KEY ("IdInventario") REFERENCES INVENTARIO(IdInventario),
CONSTRAINT Rela_VehiculosContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_VehiculosSucursal FOREIGN KEY ("IdSucursal") REFERENCES SUCURSAL(IdSucursal),
CONSTRAINT Rela_VehiculosEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado),
)*/

 --//TABLA VEHICULOS
 --PROCEDURE MOSTRAR VEHICULOS
 CREATE PROCEDURE SPMUESTRAVEHICULOS
@No_Chassis nvarchar(30)
AS
SELECT * FROM VEHICULOS WHERE No_Chassis LIKE @No_Chassis + '%'
Go

--PROCEDURE INSERTAR VEHICULOS
CREATE PROCEDURE SPINSERTAVEHICULOS
@IdInventario int,
@IdContacto int,
@IdSucursal int,
@IdEmpleado_Creador int,
@No_Chassis nvarchar(30),
@Fecha_Comprado datetime,
@Monto_Compra int,
@Color nvarchar(30),
@Motor nvarchar(30),
@Millaje int,
@Transmision nvarchar(30),
@Traccion nvarchar(30),
@Combustion nvarchar(30)
AS INSERT INTO VEHICULOS VALUES(@IdInventario, @IdContacto, @IdSucursal, @IdEmpleado_Creador, @No_Chassis, @Fecha_Comprado, @Monto_Compra, @Color, @Motor, @Millaje, @Transmision, @Traccion, @Combustion)

Go

--PROCEDURE EDITAR VEHICULOS
CREATE PROCEDURE SPEDITAVEHICULOS
@CODVehiculo nvarchar(5),
@IdInventario int,
@IdContacto int,
@IdSucursal int,
@IdEmpleado_Creador int,
@No_Chassis nvarchar(30),
@Fecha_Comprado datetime,
@Monto_Compra int,
@Color nvarchar(30),
@Motor nvarchar(30),
@Millaje int,
@Transmision nvarchar(30),
@Traccion nvarchar(30),
@Combustion nvarchar(30)
AS
UPDATE VEHICULOS SET IdInventario = @IdInventario, IdContacto = @IdContacto, IdSucursal = @IdSucursal, IdEmpleado_Creador = @IdEmpleado_Creador, No_Chassis = @No_Chassis, Fecha_Comprado = @Fecha_Comprado, Monto_Compra = @Monto_Compra, Color = @Color, Motor = @Motor, Millaje = @Millaje, Transmision = @Transmision, Traccion = @Traccion, Combustion = @Combustion where CODVehiculo = @CODVehiculo

Go

--PROCEDURE ELIMINA VEHICULOS
 CREATE PROC SPELIMINAVEHICULOS
 @CODVehiculo nvarchar(5)
 AS
 DELETE VEHICULOS WHERE CODVehiculo = @CODVehiculo

 Go

 /*
 CREATE TABLE ESTADO_VEHICULO(
IdEstado int IDENTITY(1,1) not null,
CODEstado as ('EV' + RIGHT('00' + Convert(Varchar, IdEstado), (2))),
IdVehiculo int not null,
IdEmpleado_Creador int not null,
Nota text null,
Placa nvarchar(10) null,
Matricula nvarchar(10) null,
Combustible nvarchar(30) null,
Lubricacion nvarchar(30) null,
En_Uso bit null,
Fecha_Ultima_Revision datetime null,
Revisado_Por nvarchar(20) not null, -- Departamento de Mantenimiento o un taller externo al negocio
IdContacto int null,
CONSTRAINT PkEstado_Vehiculo PRIMARY KEY(IdEstado),
CONSTRAINT Rela_Estado_VehiculoVehiculo FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculo),
CONSTRAINT Rela_Estado_VehiculoContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_InventaroEmpleado FOREIGN KEY ("IdEmpleado_Creador") REFERENCES EMPLEADOS(IdEmpleado),
)
 */

 --//TABLA ESTADO_VEHICULO
 --PROCEDURE MOSTRAR ESTADO_VEHICULO
 CREATE PROCEDURE SPMUESTRAESTADO_VEHICULO
@Placa nvarchar(10)
AS
SELECT * FROM ESTADO_VEHICULO WHERE Placa LIKE @Placa + '%'
Go

--PROCEDURE INSERTAR ESTADO_VEHICULO
CREATE PROCEDURE SPINSERTAESTADO_VEHICULO
@IdVehiculo int,
@IdEmpleado_Creador int,
@Nota text,
@Placa nvarchar(10),
@Matricula nvarchar(10),
@Combustible nvarchar(30),
@Lubricacion nvarchar(30),
@En_Uso bit,
@Fecha_Ultima_Revision datetime,
@Revisado_Por nvarchar(20),
@IdContacto int
AS INSERT INTO ESTADO_VEHICULO VALUES(@IdVehiculo, @IdEmpleado_Creador, @Nota, @Placa, @Matricula, @Combustible, @Lubricacion, @En_Uso, @Fecha_Ultima_Revision, @Revisado_Por, @IdContacto)

Go

--PROCEDURE EDITAR ESTADO_VEHICULO
CREATE PROCEDURE SPEDITAESTADO_VEHICULO
@CODEstado nvarchar(5),
@IdVehiculo int,
@IdEmpleado_Creador int,
@Nota text,
@Placa nvarchar(10),
@Matricula nvarchar(10),
@Combustible nvarchar(30),
@Lubricacion nvarchar(30),
@En_Uso bit,
@Fecha_Ultima_Revision datetime,
@Revisado_Por nvarchar(20),
@IdContacto int
AS
UPDATE ESTADO_VEHICULO SET IdVehiculo = @IdVehiculo, IdEmpleado_Creador = @IdEmpleado_Creador, Nota = @Nota, Placa = @Placa, Matricula = @Matricula, Combustible = @Combustible, Lubricacion = @Lubricacion, En_Uso = @En_Uso, Fecha_Ultima_Revision = @Fecha_Ultima_Revision, Revisado_Por = @Revisado_Por, IdContacto = @IdContacto where CODEstado = @CODEstado

Go

--PROCEDURE ELIMINA ESTADO_VEHICULO
 CREATE PROC SPELIMINAESTADO_VEHICULO
 @CODEstado nvarchar(5)
 AS
 DELETE ESTADO_VEHICULO WHERE CODEstado = @CODEstado

 Go

 /*
 CREATE TABLE CITAS(
IdCita int IDENTITY(1,1) not null,
CODCita as ('CI' + RIGHT('00' + Convert(Varchar, IdCita), (2))),
IdCliente int not null,
IdSucursal int not null,
Kilometraje int null,
Garantia nvarchar(30) null,
Observaciones text null,
Hecho_por nvarchar(30) not null, -- El sitio web/sistema de la agencia, o un turoperador intermediario
IdEmpleado int null,
IdContacto int null,
CONSTRAINT PkCitas PRIMARY KEY (IdCita),
CONSTRAINT Rela_CitasCliente FOREIGN KEY ("IdCliente") REFERENCES CLIENTES(IdCliente),
CONSTRAINT Rela_CitasContacto FOREIGN KEY ("IdContacto") REFERENCES CONTACTOS(IdContacto),
CONSTRAINT Rela_CitasSucursal FOREIGN KEY ("IdSucursal") REFERENCES SUCURSAL(IdSucursal),
CONSTRAINT Rela_CitasEmpleado FOREIGN KEY ("IdEmpleado") REFERENCES EMPLEADOS(IdEmpleado),
)
 */
 
  --//TABLA CITAS
 --PROCEDURE MOSTRAR CITAS
 CREATE PROCEDURE SPMUESTRACITAS
@CODCita nvarchar(5)
AS
SELECT * FROM CITAS WHERE CODCita LIKE @CODCita + '%'
Go

--PROCEDURE INSERTAR CITAS
CREATE PROCEDURE SPINSERTACITAS
@IdCliente int,
@IdSucursal int,
@Kilometraje int,
@Garantia nvarchar(30),
@Observaciones text,
@Hecho_por nvarchar(30),
@IdEmpleado int,
@IdContacto int = null
AS INSERT INTO CITAS VALUES(@IdCliente, @IdSucursal, @Kilometraje, @Garantia, @Observaciones, @Hecho_por, @IdEmpleado, @IdContacto)

Go

--PROCEDURE EDITAR CITAS
CREATE PROCEDURE SPEDITACITAS
@CODCita nvarchar(5),
@IdCliente int,
@IdSucursal int,
@Kilometraje int,
@Garantia nvarchar(30),
@Observaciones text,
@Hecho_por nvarchar(30),
@IdEmpleado int,
@IdContacto int = null
AS
UPDATE CITAS SET IdCliente = @IdCliente, IdSucursal = @IdSucursal, Kilometraje = @Kilometraje, Garantia = @Garantia, Observaciones = @Observaciones, Hecho_por = @Hecho_por, IdEmpleado = @IdEmpleado, IdContacto = @IdContacto where CODCita = @CODCita

Go

--PROCEDURE ELIMINA CITAS
 CREATE PROC SPELIMINACITAS
 @CODCita nvarchar(5)
 AS
 DELETE CITAS WHERE CODCita = @CODCita

 Go

 /*
 CREATE TABLE FACTURA(
	IdFactura int identity(1,1),
	CODFactura as ('FAC' + RIGHT('00' + Convert(Varchar, IdFactura), (2))),
	IdCita int not null,
	Nombre_Agencia nvarchar(50),
	RNC nvarchar(20),
	Fecha date,
	ITEBIS int,
	Descuento int,
	Total_General int,
	CONSTRAINT PkFactura PRIMARY KEY(IdFactura),
	CONSTRAINT Rela_FacturaCita FOREIGN KEY("IdCita") REFERENCES CITAS(IdCita)
)
 */
  --//TABLA FACTURA
 --PROCEDURE MOSTRAR FACTURAS
 CREATE PROCEDURE SPMUESTRAFACTURAS
@RNC nvarchar(20)
AS
SELECT * FROM FACTURA WHERE RNC LIKE @RNC + '%'
Go

--PROCEDURE INSERTAR FACTURAS
CREATE PROCEDURE SPINSERTAFACTURAS
@IdCita int,
@Nombre_Agencia nvarchar(50),
@RNC nvarchar(20),
@Fecha date,
@Total_Bruto int,
@ITEBIS int,
@Descuento int = null,
@Total_General int
AS INSERT INTO FACTURA VALUES(@IdCita, @Nombre_Agencia, @RNC, @Fecha,@Total_Bruto, @ITEBIS, @Descuento, @Total_General)

Go

--PROCEDURE EDITAR FACTURAS
CREATE PROCEDURE SPEDITAFACTURAS
@CODFactura nvarchar(5),
@IdCita int,
@Nombre_Agencia nvarchar(50),
@RNC nvarchar(20),
@Fecha date,
@Total_Bruto int,
@ITEBIS int,
@Descuento int = null,
@Total_General int
AS
UPDATE FACTURA SET IdCita = @IdCita, Nombre_Agencia = @Nombre_Agencia, RNC = @RNC, Fecha = @Fecha,Total_Bruto = @Total_Bruto, ITEBIS = @ITEBIS, Descuento = @Descuento, Total_General = @Total_General where CODFactura = @CODFactura

Go

--PROCEDURE ELIMINA FACTURAS
 CREATE PROC SPELIMINAFACTURAS
 @CODFactura nvarchar(5)
 AS
 DELETE FACTURA WHERE CODFactura = @CODFactura

 Go

 /*
 CREATE TABLE TRANSACCIONES(
	IdTransaccion int identity(1,1),
	CODTransaccion as ('TRA' + RIGHT('00' + Convert(Varchar, IdTransaccion), (2))),
	IdFactura int not null,
	IdCliente int not null,
	Monto int null,
	Fecha date,
	CONSTRAINT PkTransacciones PRIMARY KEY(IdTransaccion),
	CONSTRAINT Rela_TransaccionFactura FOREIGN KEY("IdFactura") REFERENCES FACTURA(IdFactura),
	CONSTRAINT Rela_TransaccionCliente FOREIGN KEY("IdCliente") REFERENCES CLIENTES(IdCliente),
)
 */

   --//TABLA TRANSACCIONES
 --PROCEDURE MOSTRAR TRANSACCIONES
 CREATE PROCEDURE SPMUESTRATRANSACCIONES
@CODTransaccion nvarchar(5)
AS
SELECT * FROM TRANSACCIONES WHERE CODTransaccion LIKE @CODTransaccion + '%'
Go

--PROCEDURE INSERTAR TRANSACCIONES
CREATE PROCEDURE SPINSERTATRANSACCIONES
@IdFactura int,
@IdCliente int,
@Monto int,
@Fecha date
AS INSERT INTO TRANSACCIONES VALUES(@IdFactura, @IdCliente, @Monto, @Fecha)

Go

--PROCEDURE EDITAR TRANSACCIONES
CREATE PROCEDURE SPEDITATRANSACCIONES
@CODTransaccion nvarchar(5),
@IdFactura int,
@IdCliente int,
@Monto int,
@Fecha date
AS
UPDATE TRANSACCIONES SET IdFactura = @IdFactura, IdCliente = @IdCliente, Monto = @Monto, Fecha = @Fecha where CODTransaccion = @CODTransaccion

Go

--PROCEDURE ELIMINA TRANSACCIONES
 CREATE PROC SPELIMINATRANSACCIONES
 @CODTransaccion nvarchar(5)
 AS
 DELETE TRANSACCIONES WHERE CODTransaccion = @CODTransaccion

 Go

 /*
 CREATE TABLE FOTOS(
 IdFoto int IDENTITY(1,1) not null,
 CODFoto as ('FT' + RIGHT('00' + Convert(Varchar, IdFoto), (2))),
 IdVehiculo int not null,
 Nombre nvarchar(30) null,
 Tipo_foto nvarchar(15) null,
 Link_Imagen nvarchar(30) null,
 Fecha_Foto date null,
 CONSTRAINT PkFotos PRIMARY KEY(IdFoto),
 CONSTRAINT Rela_FotosVehiculos FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculo),
)
 */
--//TABLA FOTOS
 --PROCEDURE MOSTRAR FOTOS
 CREATE PROCEDURE SPMUESTRAFOTOS
@Nombre nvarchar(30)
AS
SELECT * FROM FOTOS WHERE Nombre LIKE @Nombre + '%'
Go

--PROCEDURE INSERTAR FOTOS
CREATE PROCEDURE SPINSERTAFOTOS
@IdVehiculo int,
@Nombre nvarchar(30),
@Tipo_foto nvarchar(15),
@Link_Imagen nvarchar(30),
@Fecha_Foto date
AS INSERT INTO FOTOS VALUES(@IdVehiculo, @Nombre, @Tipo_foto, @Link_Imagen, @Fecha_Foto)

Go

--PROCEDURE EDITAR FOTOS
CREATE PROCEDURE SPEDITAFOTOS
@CODFoto nvarchar(5),
@IdVehiculo int,
@Nombre nvarchar(30),
@Tipo_foto nvarchar(15),
@Link_Imagen nvarchar(30),
@Fecha_Foto date
AS
UPDATE FOTOS SET IdVehiculo = @IdVehiculo, Nombre = @Nombre, Tipo_foto = @Tipo_foto, Link_Imagen = @Link_Imagen, Fecha_Foto = @Fecha_Foto where CODFoto = @CODFoto

Go

--PROCEDURE ELIMINA FOTOS
 CREATE PROC SPELIMINAFOTOS
 @CODFoto nvarchar(5)
 AS
 DELETE FOTOS WHERE CODFoto = @CODFoto

 Go

 /*
 CREATE TABLE RESERVAS_ORDENES(
	IdCita int not null,
	IdVehiculo int not null,
	Fecha_Entrega date,
	Fecha_devolucion date,
	Tiempo as CONCAT(DATEDIFF(year,Fecha_devolucion, Fecha_Entrega),':', DATEDIFF(month, Fecha_devolucion, Fecha_Entrega),':',DATEDIFF(day,Fecha_devolucion, Fecha_Entrega),' : ', DATEDIFF(hour, Fecha_devolucion, Fecha_Entrega),':', DATEDIFF(minute, Fecha_devolucion, Fecha_Entrega),':', DATEDIFF(second, Fecha_devolucion, Fecha_Entrega)),
	En_Proceso nvarchar(15) null,
	Utilidad text null,
	MetodoPago nvarchar(30) not null, --Liquido o tarjeta
	Tarifa int null,
	Total_Pag int null,
	Num_Poliza nvarchar(30) null,
	CONSTRAINT Rela_OrdenCita FOREIGN KEY ("IdCita") REFERENCES CITAS(IdCita),
	CONSTRAINT Rela_OrdenVehiculo FOREIGN KEY ("IdVehiculo") REFERENCES VEHICULOS(IdVehiculos)
)
 */

--//TABLA RESERVAS_ORDENES
 --PROCEDURE MOSTRAR ORDENES
 CREATE PROCEDURE SPMUESTRAORDENES
@Num_Poliza nvarchar(30)
AS
SELECT * FROM RESERVAS_ORDENES WHERE Num_Poliza LIKE @Num_Poliza + '%'

Go

--PROCEDURE INSERTAR ORDEN
CREATE PROCEDURE SPINSERTAORDENES
@IdCita int,
@IdVehiculo int,
@Fecha_Entrega datetime,
@Fecha_devolucion datetime,
@En_Proceso nvarchar(15),
@Utilidad text,
@MetodoPago nvarchar(30), 
@Tarifa int,
@Total_Pag int,
@Num_Poliza nvarchar(30)
AS INSERT INTO RESERVAS_ORDENES VALUES(@IdCita, @IdVehiculo, @Fecha_Entrega, @Fecha_devolucion, @En_Proceso, @Utilidad, @MetodoPago, @Tarifa, @Total_Pag, @Num_Poliza)

Go

--PROCEDURE EDITAR ORDEN
CREATE PROCEDURE SPEDITAORDENES
@IdCita int,
@IdVehiculo int,
@Fecha_Entrega datetime,
@Fecha_devolucion datetime,
@En_Proceso nvarchar(15),
@Utilidad text,
@MetodoPago nvarchar(30), 
@Tarifa int,
@Total_Pag int,
@Num_Poliza nvarchar(30)
AS
UPDATE RESERVAS_ORDENES SET Fecha_Entrega = @Fecha_Entrega, Fecha_devolucion = @Fecha_devolucion, En_Proceso = @En_Proceso, Utilidad = @Utilidad, MetodoPago = @MetodoPago, Tarifa = @Tarifa, Total_Pag = @Total_Pag, Num_Poliza = @Num_Poliza where IdVehiculo = @IdVehiculo and IdCita = @IdCita

Go

--PROCEDURE ELIMINA ORDEN
 CREATE PROC SPELIMINAORDENES
 @Num_Poliza nvarchar(30)
 AS
 DELETE RESERVAS_ORDENES WHERE Num_Poliza = @Num_Poliza 

 Go