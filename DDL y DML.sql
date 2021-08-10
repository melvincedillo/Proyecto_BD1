---------------------------------------------------------------------------------------------------------------------------------------
--                                      D D L SISTEMA DE RENTAS DE AUTOS
---------------------------------------------------------------------------------------------------------------------------------------
--GRUPO 3

create table DEPARTAMENTO(
    departamentoID int,
    departamento varchar(20) not null,
    CONSTRAINT departamentoPK PRIMARY KEY(departamentoID)
);

CREATE TABLE MUNICIPIO(
	municipioID INT ,
	municipio VARCHAR(20) NOT NULL,
    departamentoid int,
	CONSTRAINT municipioPK PRIMARY KEY (municipioID),
	CONSTRAINT departamentoFK FOREIGN KEY (departamentoID) REFERENCES DEPARTAMENTO (departamentoID)
);

CREATE TABLE DIRECCION(
    direccionID INT,
	municipioID INT,
    col_aldea varchar(50),
    calle varchar(50),
    casa int,
    CONSTRAINT direccionPK PRIMARY KEY (direccionID),
	CONSTRAINT municipioFK FOREIGN KEY (municipioID) REFERENCES MUNICIPIO (municipioID)
);

create table DANIO(
    danioID int,
    danio varchar(20) not null,
    costo float not null,
    CONSTRAINT danioPK PRIMARY KEY(danioID)
); 

CREATE TABLE ORIGEN(
	origenID INT,
	pais VARCHAR(20) NOT NULL,
	CONSTRAINT origenPK PRIMARY KEY (origenID),
	CONSTRAINT pais UNIQUE (pais)
);

create table MARCA(
    marcaID int,
    marca varchar(20) not null,
    origenID int,
    CONSTRAINT marcaPK PRIMARY KEY(marcaID),
    CONSTRAINT origenFK FOREIGN KEY (origenID) REFERENCES ORIGEN(origenID)
);

create table COMBUSTIBLE(
    combustibleID int,
    combustible varchar(20) not null,
    CONSTRAINT combustiblePK PRIMARY KEY(combustibleID)
);

create table TIPO_VEHICULO(
    tipo_vehiculoID int,
    tipo_vehiculo varchar(20) not null,
    CONSTRAINT tipo_vehiculoPK PRIMARY KEY(tipo_vehiculoID)
);

CREATE TABLE MODELO(
	modeloID INT,
	modelo VARCHAR(20) NOT NULL,
	CONSTRAINT modeloPK PRIMARY KEY (modeloID)
);

CREATE TABLE COLOR(
	colorID INT,
	color VARCHAR(20) NOT NULL,
	CONSTRAINT colorPK PRIMARY KEY (colorID)
);

CREATE TABLE VERSION(
	versionID INT,
	version VARCHAR(20) NOT NULL,
	CONSTRAINT versionPK PRIMARY KEY (versionID)
);


CREATE TABLE ESTADO(
	estadoID INT, 
	estado varchar (20) NOT NULL,
	CONSTRAINT estadoPK  PRIMARY KEY (estadoID)
);

create table SUCURSAL(
    sucursalID int,
    sucursal varchar(20) not null,
    direccionID int not null,
    CONSTRAINT sucursalPK PRIMARY KEY(sucursalID),
    CONSTRAINT direccionSucursalFK foreign key(direccionID) references DIRECCION(direccionID)
);

create table EMPLEADO(
    empleadoID int,
    nombre varchar(20) not null,
    p_nombre varchar(20) not null,
    s_nombre varchar(20),
    p_apellido varchar(20) not null,
    s_apellido varchar(20),
    identidad varchar(20) not null UNIQUE,
    sueldo float not null,
    horasExtras float,
    fecha_ingreso date not null,
    sexo VARCHAR(15) not null,
    sucursalID int not null,
    CONSTRAINT empleadoPK PRIMARY KEY(empleadoID),
    CONSTRAINT sucursalEmpleadoPK foreign key(sucursalID) references SUCURSAL(sucursalID)
);

create table VEHICULO(
    vehiculoID int,
    placa varchar(20) not null UNIQUE,
    fecha_adquisicion date not null,
    costo_vehiculo float not null,
    costo_renta float not null,
    combustibleID int not null,
    modeloID int not null,
    marcaID int not null,
    colorID int not null,
    tipo_vehiculoID int not null,
    versionID int not null,
    estadoID int not null,
    seguro float not null,
    CONSTRAINT vehiculoPK PRIMARY KEY(vehiculoID),
    CONSTRAINT combustibleVehiculoPK foreign key(combustibleID) references COMBUSTIBLE(combustibleID),
    CONSTRAINT modeloVehiculoPK foreign key(modeloID) references MODELO(modeloID),
    CONSTRAINT marcaVehiculoPK foreign key(marcaID) references MARCA(marcaID),
    CONSTRAINT colorVehiculoPK foreign key(colorID) references COLOR(colorID),
    CONSTRAINT tipo_vehiculoVehiculoPK foreign key(tipo_vehiculoID) references TIPO_VEHICULO(tipo_vehiculoID),
    CONSTRAINT versionVehiculoPK foreign key(versionID) references VERSION(versionID),
    CONSTRAINT estadoVehiculoPK foreign key(estadoID) references ESTADO(estadoID)
);


CREATE TABLE CLIENTE(
	clienteID INT,
	p_nombre VARCHAR(20) NOT NULL,
	s_nombre VARCHAR(20) NOT NULL,
	p_apellido VARCHAR(20) NOT NULL,
	s_apellido VARCHAR(20) NOT NULL,
	identidad VARCHAR(20) NOT NULL UNIQUE,
	rtn VARCHAR(20) NOT NULL UNIQUE,
	sexo VARCHAR(15),
	direccionID INT NOT NULL,
	CONSTRAINT clientePK PRIMARY KEY (clienteID),
    CONSTRAINT direccionClienteFK FOREIGN KEY (direccionID) REFERENCES DIRECCION (direccionID)
);

CREATE TABLE TELEFONOxCLIENTE(
	clienteID INT NOT NULL,
	telefono VARCHAR (20) UNIQUE,
    pos int,
	CONSTRAINT clienteFK FOREIGN KEY (clienteID) REFERENCES  CLIENTE (clienteID)
);

CREATE TABLE TELEFONOxEMPLEADO(
	empleadoID INT NOT NULL,
	telefono VARCHAR(20) NOT NULL UNIQUE,
	CONSTRAINT telefonoxempleadoFK FOREIGN KEY (empleadoID) REFERENCES EMPLEADO (empleadoID)
);

CREATE TABLE TELEFONOxSUCURSAL(
	sucursalID INT NOT NULL,
	telefono VARCHAR(20) NOT NULL UNIQUE,
	CONSTRAINT sucursalTelFK FOREIGN KEY (sucursalID) REFERENCES SUCURSAL (sucursalID)
);

CREATE TABLE REFERENCIA(
	referenciaID INT,
	p_nombre VARCHAR(20) NOT NULL,
	s_nombre VARCHAR(20) NOT NULL,
	p_apellido VARCHAR(20) NOT NULL,
	s_apellido VARCHAR(20) NOT NULL,
	relacion VARCHAR(20) NOT NULL,
	telefono VARCHAR(20) NOT NULL,
    direccionID INT NOT NULL,
	CONSTRAINT referenciaPK PRIMARY KEY (referenciaID),
	CONSTRAINT direccionReferenciaFK FOREIGN KEY (direccionID) REFERENCES DIRECCION (direccionID)
);

CREATE TABLE CLIENTExREFERENCIA(
	clienteID INT NOT NULL,
	referenciaID INT NOT NULL,
	CONSTRAINT clienteRefFK FOREIGN KEY (clienteID) REFERENCES CLIENTE (clienteID),
	CONSTRAINT referenciaClienteFK FOREIGN KEY (referenciaID) REFERENCES REFERENCIA (referenciaID)
);

create table estado_solicitud(
    estadoid int,
    estado varchar(20),
    constraint e_s_PK primary key (estadoid)
);

create table SOLICITUD(
    solicitudID int,
    fecha_solicitud date not null,
    subtotal float not null,
    sucursalID int not null,
    vehiculoID int not null,
    fecharInicio date not null,
    fechaFin date not null,
    clienteID int not null,
    empleadoid int,
    estadoid int,
    seguro varchar(5),
    CONSTRAINT solicitudPK PRIMARY KEY(solicitudID),
    CONSTRAINT sucursalSolicitudPK foreign key(sucursalID) references SUCURSAL(sucursalID),
    CONSTRAINT vehiculoSolicitudPK foreign key(vehiculoID) references VEHICULO(vehiculoID),
    CONSTRAINT clienteSolicitudPK foreign key(clienteID) references CLIENTE(clienteID),
    CONSTRAINT empleadoSolicitudPK foreign key(empleadoid) references EMPLEADO(empleadoID),
    CONSTRAINT estadoSolicitudFK foreign key(estadoid) references estado_solicitud(estadoid)
);

create table CONTRATO(
    contratoID int,
    fecha date not null,
    subtotal float not null,
    iva int not null,
    total float not null,
    solicitudID int not null,
    CONSTRAINT contratoPK PRIMARY KEY(contratoID),
    CONSTRAINT direccionFinFK FOREIGN KEY (dir_finID) REFERENCES DIRECCION (direccionID)
);


create table TIPO_PAGO(
    tipo_PagoID int,
    tipo_Pago varchar(20) not null,
    CONSTRAINT tipo_PagoPK PRIMARY KEY(tipo_pagoID)
); 

CREATE TABLE PAGO(
	pagoID INT,
	total_pagado FLOAT NOT NULL,
	tipo_pagoID INT,
    contratoID INT,
	CONSTRAINT pagoPK PRIMARY KEY (pagoID),
	CONSTRAINT tipo_pagoFK FOREIGN KEY (tipo_pagoID) REFERENCES TIPO_PAGO (tipo_pagoID),
    CONSTRAINT contrato_pagoFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID)
);

CREATE TABLE DEVOLUCION(
    devolucionID INT,
    contratoID INT,
    fecha DATE,
    CONSTRAINT devPK PRIMARY KEY(devolucionID),
    CONSTRAINT contratoDevolucionFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID)
);

CREATE TABLE DEVOLUCIONxDANIOS(
    devolucionID INT,
    danioID INT,
    CONSTRAINT devolucionFK FOREIGN KEY (devolucionID) REFERENCES DEVOLUCION(devolucionID),
    CONSTRAINT danioFK FOREIGN KEY (danioID) REFERENCES DANIO(danioID)
);



-------------------------------------------------------------------------------------------------------------------------------------
--                                                 D M L SISTEMA RENTAS DE AUTOS
-------------------------------------------------------------------------------------------------------------------------------------
--Insertar datos estado_Solicitud
insert into estado_solicitud values (0, 'En espera');
insert into estado_solicitud values (1, 'Ejecutando');
insert into estado_solicitud values (2, 'Sin cancelar');
insert into estado_solicitud values (3, 'Cerrado');


--Insertando Datos Municipio
INSERT INTO MUNICIPIO VALUES(1,'La Ceiba', 1);
INSERT INTO MUNICIPIO VALUES(3,'Tela', 1);
INSERT INTO MUNICIPIO VALUES(2,'Jutiapa', 1);

INSERT INTO MUNICIPIO VALUES(4,'Trujillo', 2);
INSERT INTO MUNICIPIO VALUES(5,'Balfate', 2);
INSERT INTO MUNICIPIO VALUES(6,'Iriona', 2);

INSERT INTO MUNICIPIO VALUES(7,'Comayagua', 3);
INSERT INTO MUNICIPIO VALUES(8,'Ajuterique', 3);
INSERT INTO MUNICIPIO VALUES(9,'El Rosario', 3);

--Insertando datos tabla Tipo_Renta
INSERT INTO TIPO_RENTA VALUES(1,'Por Hora', 300);
INSERT INTO TIPO_RENTA VALUES(2,'Por Dia', 1500);
INSERT INTO TIPO_RENTA VALUES(3,'Por Mes', 15000);
INSERT INTO TIPO_RENTA VALUES(4,'Por Año', 60000);

--Insertando datos Version
INSERT INTO VERSION VALUES(1,'JAPONES');
INSERT INTO VERSION VALUES(2,'AMERICANO');
INSERT INTO VERSION VALUES(3,'CANADINSE');
INSERT INTO VERSION VALUES(4,'EUROPERO');
INSERT INTO VERSION VALUES(5,'RUSO');


--Insetando datos Color
INSERT INTO COLOR VALUES(1, 'Blanco');
INSERT INTO COLOR VALUES(2, 'Rojo');
INSERT INTO COLOR VALUES(3, 'Gris');
INSERT INTO COLOR VALUES(4, 'Negro');
INSERT INTO COLOR VALUES(5, 'Azul');
INSERT INTO COLOR VALUES(6, 'Amarillo');
INSERT INTO COLOR VALUES(7, 'Verde');
INSERT INTO COLOR VALUES(8, 'Morado');
INSERT INTO COLOR VALUES(9, 'Naranja');
INSERT INTO COLOR VALUES(10, 'Plateado');

--Insertando datos Modelo
INSERT INTO MODELO VALUES(1, 'Pick Up');
INSERT INTO MODELO VALUES(2, 'Camioneta');
INSERT INTO MODELO VALUES(3, 'Turismo');
INSERT INTO MODELO VALUES(4, 'Mini Band');
INSERT INTO MODELO VALUES(5, 'Camion');

--Insertando datos Origen
INSERT INTO ORIGEN VALUES(1,'Japón');
INSERT INTO ORIGEN VALUES(2,'Honduras');
INSERT INTO ORIGEN VALUES(3,'Alemania');
INSERT INTO ORIGEN VALUES(4,'Estados Unidos');
INSERT INTO ORIGEN VALUES(5,'Brazil');
INSERT INTO ORIGEN VALUES(6,'China');
INSERT INTO ORIGEN VALUES(7,'España');
INSERT INTO ORIGEN VALUES(8,'Costa Rica');
INSERT INTO ORIGEN VALUES(9,'Perú');
INSERT INTO ORIGEN VALUES(10,'Canadá'); 

--insertando en tabla marca
INSERT INTO MARCA VALUES(1,'FORD', 4);
INSERT INTO MARCA VALUES (3, 'NISSAN', 4);
INSERT INTO MARCA VALUES (4,'TOYOTA', 5);
INSERT INTO MARCA VALUES (5,'MERCEDES BENZ', 5);
INSERT INTO MARCA VALUES  (6,'BMW', 4);
INSERT INTO MARCA VALUES (7,'HONDA', 5);
INSERT INTO MARCA VALUES (8, 'HYUNDAI', 3);
INSERT INTO MARCA VALUES (9,'TESLA', 10);
INSERT INTO MARCA VALUES (10,'VOLSWAGEN', 6);
INSERT INTO MARCA VALUES (11,'KIA', 4);

--insertando tabla combustible
INSERT INTO COMBUSTIBLE VALUES(1,'Gasolina');
INSERT INTO COMBUSTIBLE VALUES(2,'Diesel');

--insertando tabla tipo_vehiculo
INSERT INTO TIPO_VEHICULO VALUES(1,'2 cilindros');
INSERT INTO TIPO_VEHICULO VALUES(2,'3 cilindros');
INSERT INTO TIPO_VEHICULO VALUES(3,'4 cilindros');
INSERT INTO TIPO_VEHICULO VALUES (4,'6 cilindros'); 
INSERT INTO TIPO_VEHICULO VALUES (5,'8 cilindros');

--insertando tabla estado
INSERT INTO ESTADO VALUES(0,'Disponible');
INSERT INTO ESTADO VALUES(1,'En espera');
INSERT INTO ESTADO VALUES(2,'Rentado');
INSERT INTO ESTADO VALUES(3,'En Mantenimiento');


--Insertando datos tabla tipo Danio;
INSERT INTO DANIO VALUES (1, 'Cambio de Aceite', 1000);
INSERT INTO DANIO VALUES (2, 'Cambio de llantas', 1500);
INSERT INTO DANIO VALUES (3, 'Reparacion de trompa', 3000);
INSERT INTO DANIO VALUES (4, 'Reparacion puerta trasera', 3500);
INSERT INTO DANIO VALUES (5, 'Reparacion de frenos', 500);
INSERT INTO DANIO VALUES (6, 'Reparacion de parabrisas', 400);
INSERT INTO DANIO VALUES (7, 'Cambio de tablero', 450);
INSERT INTO DANIO VALUES (8, 'Cambio de rines', 2000);
INSERT INTO DANIO VALUES (9, 'Cambio de motor', 10000);
INSERT INTO DANIO VALUES (10, 'Cambio de suspencion', 350);

--Insertando datos tabla Departamento
insert into departamento values (1,'Atlántida');
insert into departamento values (2,'Colón');
insert into departamento values (3,'Comayagua');
insert into departamento values (4,'Copán');
insert into departamento values (5,'Cortés');
insert into departamento values (6,'Choluteca');
insert into departamento values (7,'El Paraíso');
insert into departamento values (8,'Francisco Morazán');
insert into departamento values (9,'Gracias a Dios');
insert into departamento values (10,'Intibucá');
insert into departamento values (11,'Islas de la Bahía');
insert into departamento values (12,'La Paz');
insert into departamento values (13,'Lempira');
insert into departamento values (14,'Ocotepeque');
insert into departamento values (15,'Olancho');
insert into departamento values (16,'Santa Bárbara');
insert into departamento values (17,'Valle');
insert into departamento values (18,'Yoro');

--Insertando direcciones
INSERT INTO MUNICIPIO VALUES(10,'Tegucigalpa', 8);
INSERT INTO DIRECCION VALUES (2, 8,'Col. Miraflores', 'UNPFM', 230);
INSERT INTO DIRECCION VALUES (2, 2, 10, 'aldea san jose, calle 10');
INSERT INTO DIRECCION VALUES (3, 3, 10, 'aldea bañaderos, calle 7');
INSERT INTO DIRECCION VALUES (4, 1, 4, 'pueblo san juan, sector 9, casa 3');
INSERT INTO DIRECCION VALUES (5, 5, 3, 'col. cabaña, sector 2, calle 4');
INSERT INTO DIRECCION VALUES (6, 2, 1, 'col. cedillo, calle romero, casa 48');
INSERT INTO DIRECCION VALUES (7, 7, 9, 'aldea unida, casa 23');
INSERT INTO DIRECCION VALUES (8, 4, 7, 'aldea plan verde, casa 4');
INSERT INTO DIRECCION VALUES (9, 9, 6, 'tegucigalpa, col. hato, casa 600');
INSERT INTO DIRECCION VALUES (10, 8, 5, 'aldea el carmen, casa 23');
INSERT INTO DIRECCION VALUES (11, 2, 4, 'aldea el tablon, casa 50');
INSERT INTO DIRECCION VALUES (12, 9, 3, 'aldea san fernado, casa 2');

--Insertando Sucursal
INSERT INTO SUCURSAL VALUES (1, 'RENTA CAR', 2);

delete from direccion;
--Insertando datos tabla Empleado
INSERT INTO EMPLEADO VALUES (1, 'Maria Lopez', 'Maria', 'Ester', 'Lopez', 'Rodriguez', '0701199400113', 5500, 10, DATE'2021-05-10', 'F', 1);
INSERT INTO EMPLEADO VALUES (2, 'Juan Montes', 'Juan', 'Jose', 'Montes', 'Altamirano', '0701199100220', 9500, 15, DATE'2021-11-14', 'M', 1);
INSERT INTO EMPLEADO VALUES (3, 'Rafael F', 'Rafael', 'Alberto', 'Figueroa', 'Medina', '0701199700340', 10000, 12,DATE'2021-12-23', 'M', 1);
INSERT INTO EMPLEADO VALUES (4, 'Benito Madrid', 'Benito', 'Roberto', 'Madrid', 'Osorio', '0701198900430', 8500, 20, DATE'2021-08-10', 'M', 1);
INSERT INTO EMPLEADO VALUES (5, 'Marta Reyes', 'Marta', 'Alejandra', 'Reyes', 'Lopez', '0701199000120', 7500, 20, DATE'2021-11-11', 'F', 1);
INSERT INTO EMPLEADO VALUES (6, 'Madiel Mendez', 'Madiel', 'Orlando', 'Mendez', 'Reina', '0701199400679', 6500, 20, DATE'2021-02-22', 'M', 1);
INSERT INTO EMPLEADO VALUES (7, 'Oscar Aguilar', 'Oscar', 'Mauricio', 'Aguilar', 'Mendoza', '0701199400320', 9500, 20, DATE'2021-12-24', 'M', 1);
INSERT INTO EMPLEADO VALUES (8, 'Andres Martinez', 'Andres', 'Omar', 'Martinez', 'Palomo', '0701199500134', 11000, 20, DATE'2021-10-23', 'M', 1);
INSERT INTO EMPLEADO VALUES (9, 'Victor Gonzales', 'Victor', 'Manuel', 'Gonzales', 'Reyes', '0701199100200', 12000, 20, DATE'2021-08-12', 'M', 1);
INSERT INTO EMPLEADO VALUES (10, 'Angelica A', 'Angelica', 'Alexandra', 'Alvarado', 'Pineda', '0701199600300', 13000, 20, DATE'2021-11-29', 'F', 1);

--Insertando datos Cliente
INSERT INTO CLIENTE (p_nombre, s_nombre, p_apellido, s_apellido, identidad, rtn, sexo, direccionid) VALUES('Erika','Gineth','Valladares','Videa','0801-2000-03103','0801-2000-031059','M',10);
INSERT INTO CLIENTE VALUES(2,'Jean','Pierre','Picado','Juárez','0801-2002-08787','0801-2002-087879','F',2);
INSERT INTO CLIENTE VALUES(3,'Melvin','Elias','Cedillo','Romero','0801-1999-87676','0801-1999-876767','F',3);
INSERT INTO CLIENTE VALUES(4,'Ronald','Denilson','Méndez','Osorio','0801-1998-90876','0801-1998-90876','F',5);
INSERT INTO CLIENTE VALUES(5,'Stefany','Alejandra','Méndez','Osorio','0801-1999-89765','0801-1999-89765','M',4);
INSERT INTO CLIENTE VALUES(6,'Héctor','Javier','Méndez','Osorio','0801-1998-45653','0801-1998-45653','F',6);
INSERT INTO CLIENTE VALUES(7,'Heydi','Sarahi','Murillo','Flores','1502-1995-23453','1502-1995-23453','M',7);
INSERT INTO CLIENTE VALUES(8,'Hector','Jose','Duarte','Pavón','0801-1976-23433','0801-1976-23433','M',8);
INSERT INTO CLIENTE VALUES(9,'Karla','Sofia','Videa','Flores','0801-1974-13296','0801-1974-132967','F',9);
INSERT INTO CLIENTE VALUES(10,'Israel','Alexander','Garcia','Videa','0801-2002-90008','0801-2002-900086','M',10);

--Insertando datos tabla Vehiculo
INSERT INTO VEHICULO VALUES (2, 'hurj784', DATE'2021-08-09', 2500, 1, 1, 1, 1, 1, 1, 1, 1);
INSERT INTO VEHICULO VALUES (3, 'rg43gb3', DATE'2021-08-10', 3000, 2, 2, 3, 2, 2, 2, 1, 1);
INSERT INTO VEHICULO VALUES (4, '8k9hn49', DATE'2021-09-30', 4400, 2, 3, 3, 3, 3, 3, 1, 3902);
INSERT INTO VEHICULO VALUES (5, 'ag6j8m9', DATE'2021-10-23', 5500, 1, 4, 4, 4, 4, 4, 1, 8732);
INSERT INTO VEHICULO VALUES (6, '00nuji8', DATE'2021-11-02', 2000, 2, 5, 5, 5, 5, 5, 1, 6739);
INSERT INTO VEHICULO VALUES (7, 'dlponyu', DATE'2021-04-08', 4500, 1, 4, 6, 6, 4, 3, 1, 78932);
INSERT INTO VEHICULO VALUES (8, '00989er', DATE'2021-03-01', 6500, 2, 5, 7, 7, 3, 5, 1, 79372);
INSERT INTO VEHICULO VALUES (9, 'pac356m', DATE'2021-05-07', 7500, 1, 2, 8, 8, 2, 3, 1, 67832);
INSERT INTO VEHICULO VALUES (10, 'wpackm', DATE'2021-06-10', 9500, 2, 3, 9, 9, 1, 2, 1, 6372);
INSERT INTO VEHICULO VALUES (11, 'nice367', DATE'2021-05-22', 8500, 1, 1, 10, 5, 4, 3, 1, 6382);

--Insertando tabla entregar
INSERT INTO ENTREGAR VALUES (1, 2, DATE'2021-12-30'); 
INSERT INTO ENTREGAR VALUES (2, 3, DATE'2021-09-07');
INSERT INTO ENTREGAR VALUES (3, 2, DATE'2021-10-10');
INSERT INTO ENTREGAR VALUES (4, 5, DATE'2021-09-22');
INSERT INTO ENTREGAR VALUES (5, 6, DATE'2021-10-16');

--Insertando tabla recibir
INSERT INTO RECIBIR VALUES (1, 2, DATE'2021-11-30'); 
INSERT INTO RECIBIR VALUES (2, 3, DATE'2021-09-10');
INSERT INTO RECIBIR VALUES (3, 2, DATE'2021-10-30');
INSERT INTO RECIBIR VALUES (4, 5, DATE'2021-09-29');
INSERT INTO RECIBIR VALUES (5, 6, DATE'2021-12-16');

--Insertando tabla Referencia
INSERT INTO REFERENCIA VALUES (1, 'Juan','Jose','Lopez','Vasquez','Amigo','99-03-89-90',2);
INSERT INTO REFERENCIA VALUES (2, 'Leticia','Maribel','Argueta','Velasquez', 'Hermana', '32-87-46-89', 3);
INSERT INTO REFERENCIA VALUES (3, 'Jessica','Sarahi','Gonzales','Flores','Tia','98-02-34-26', 5);
INSERT INTO REFERENCIA VALUES (4, 'Fernando','Josue','Fiallos','Rodriguez','Hermano','32-98-89-90', 9);
INSERT INTO REFERENCIA VALUES (5, 'Jayson', 'Francisco', 'Sanchez', 'Maradiaga','Abuelo','96-56-67-23', 10);
INSERT INTO REFERENCIA VALUES (6, 'Valeria','Jackeline','Posadas','Lagos','Esposa','97-34-22-21', 2);
INSERT INTO REFERENCIA VALUES (7, 'Lucia','Gabriela','Chicas','Orellana','Tia','97-65-32-65', 1);
INSERT INTO REFERENCIA VALUES (8, 'Sebastian','Jose','Montoya', 'Sales','Prima','95-23-45-67', 4);
INSERT INTO REFERENCIA VALUES (9, 'Jose','Luis','Montes','Alvarado','amigo','98-43-12-08', 5);
INSERT INTO REFERENCIA VALUES (10, 'Gloria','Jazmin','Pacheco','Rodas', 'Amiga','96-34-56-89', 9);

--Insertando datos en la tabla REFERENCIAxCLIENTES
INSERT INTO CLIENTEXREFERENCIA VALUES (1,2);
INSERT INTO CLIENTEXREFERENCIA VALUES (1,4);
INSERT INTO CLIENTEXREFERENCIA VALUES (1,8);
INSERT INTO CLIENTEXREFERENCIA VALUES (2,4);
INSERT INTO CLIENTEXREFERENCIA VALUES (2,9);
INSERT INTO CLIENTEXREFERENCIA VALUES (3,9);
INSERT INTO CLIENTEXREFERENCIA VALUES (4,9);
INSERT INTO CLIENTEXREFERENCIA VALUES (4,2);
INSERT INTO CLIENTEXREFERENCIA VALUES (4,10);
INSERT INTO CLIENTEXREFERENCIA VALUES (5,7);

--Insertando datos tabla Solicitud
INSERT INTO SOLICITUD VALUES (1, DATE'2021-09-09', 1, 2500, 1, 7, 1, 1, 1);
INSERT INTO SOLICITUD VALUES (2, DATE'2021-10-11', 2, 3000, 1, 2, 2, 2, 2);
INSERT INTO SOLICITUD VALUES (3, DATE'2021-02-01', 2, 1500, 1, 3, 3, 3, 3);
INSERT INTO SOLICITUD VALUES (4, DATE'2021-03-04', 1, 3500, 1, 4, 4, 4, 4);
INSERT INTO SOLICITUD VALUES (5, DATE'2021-04-04', 2, 4500, 1, 5, 5, 5, 5);

--Insertanto tipos de pago
INSERT INTO TIPO_PAGO VALUES (1, 'Efectivo');
INSERT INTO TIPO_PAGO VALUES (2, 'Tarjeta');

--Insertando tabla telefonoXcliente
INSERT INTO TELEFONOXCLIENTE VALUES (2,'96-67-87-90');
INSERT INTO TELEFONOXCLIENTE VALUES (3,'88-90-23-15');
INSERT INTO TELEFONOXCLIENTE VALUES (8,'96-78-34-56');
INSERT INTO TELEFONOXCLIENTE VALUES (1,'99-59-60-34');
INSERT INTO TELEFONOXCLIENTE VALUES (8,'96-01-65-49');
INSERT INTO TELEFONOXCLIENTE VALUES (2,'88-91-78-09');
INSERT INTO TELEFONOXCLIENTE VALUES (6,'87-95-21-02');
INSERT INTO TELEFONOXCLIENTE VALUES (2,'86-90-87-09');
INSERT INTO TELEFONOXCLIENTE VALUES (4,'32-91-45-06');
INSERT INTO TELEFONOXCLIENTE VALUES (1,'88-19-23-51');

--INSERTANDO TABLA TELEFONOXEMPLEADO
INSERT INTO TELEFONOXEMPLEADO VALUES (4,'99-01-32-87');
INSERT INTO TELEFONOXEMPLEADO VALUES (7,'97-04-22-91');
INSERT INTO TELEFONOXEMPLEADO VALUES (1,'88-23-43-21');
INSERT INTO TELEFONOXEMPLEADO VALUES (6,'33-41-56-78');
INSERT INTO TELEFONOXEMPLEADO VALUES (2,'89-03-78-90');
INSERT INTO TELEFONOXEMPLEADO VALUES (9,'98-76-45-23');
INSERT INTO TELEFONOXEMPLEADO VALUES (5,'32-57-65-43');
INSERT INTO TELEFONOXEMPLEADO VALUES (2,'96-80-43-02');
INSERT INTO TELEFONOXEMPLEADO VALUES (4,'95-23-56-80');


--INSERTANDO TABLA TELEFONOXSUCURSALL
INSERT INTO TELEFONOXSUCURSAL VALUES (1,'2298-2309');
INSERT INTO TELEFONOXSUCURSAL VALUES (1,'2244-9087');
INSERT INTO TELEFONOXSUCURSAL VALUES (1,'2284-7654');
INSERT INTO TELEFONOXSUCURSAL VALUES (1,'2258-0986');

--Insertando datos tabla contrato;
INSERT INTO CONTRATO VALUES (1, DATE'2021-08-09', 200, 0.15, 500 , 1);
INSERT INTO CONTRATO VALUES (2, DATE'2021-09-30', 300, 0.15, 1500, 2);
INSERT INTO CONTRATO VALUES (3, DATE'2021-07-11', 500, 0.15, 500, 3);
INSERT INTO CONTRATO VALUES (4, DATE'2021-02-15', 1500, 0.15, 2000, 4);
INSERT INTO CONTRATO VALUES (5, DATE'2021-01-02', 2500, 0.15, 2500, 5);

--Insertanto Pagos
INSERT INTO PAGO VALUES (1, 2000, 0, 2, 2);
INSERT INTO PAGO VALUES (2, 2500, 0, 2, 2);
INSERT INTO PAGO VALUES (3, 3000, 0, 2, 2);
INSERT INTO PAGO VALUES (4, 3300, 200, 1, 2);
INSERT INTO PAGO VALUES (5, 2400, 100, 1, 2);

--Insertando datos tabla Devolucion
INSERT INTO DEVOLUCION VALUES(1, 1, 3, DATE'2021-12-30');
INSERT INTO DEVOLUCION VALUES(2, 2, 9, DATE'2021-07-05');
INSERT INTO DEVOLUCION VALUES(3, 3, 5, DATE'2021-05-09');
INSERT INTO DEVOLUCION VALUES(4, 4, 9, DATE'2021-09-04');
INSERT INTO DEVOLUCION VALUES(5, 5, 1, DATE'2021-04-09');

--Insertando datos en tabla DEVOLUCIONXDANIOS
INSERT INTO DEVOLUCIONXDANIOS VALUES (1,1);
INSERT INTO DEVOLUCIONXDANIOS VALUES (1,2);
INSERT INTO DEVOLUCIONXDANIOS VALUES (1,3);
INSERT INTO DEVOLUCIONXDANIOS VALUES (4,7);
INSERT INTO DEVOLUCIONXDANIOS VALUES (4,5);

----------------------------------------------------------------------------






