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
    grado varchar(20) not null,
    costo_aproximado float not null,
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
    CONSTRAINT solicitudContratoFK FOREIGN KEY (solicitudID) REFERENCES SOLICITUD (solicitudID)
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
    n_tarjeta VARCHAR(20),
    expira VARCHAR(5),
    codigo INT,
    contratoID INT,
	CONSTRAINT pagoPK PRIMARY KEY (pagoID),
	CONSTRAINT tipo_pagoFK FOREIGN KEY (tipo_pagoID) REFERENCES TIPO_PAGO (tipo_pagoID),
    CONSTRAINT contrato_pagoFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID)
);


CREATE TABLE DEVOLUCION(
    devolucionID INT,
    contratoID INT,
    fecha DATE,
    danioID int,
    CONSTRAINT devPK PRIMARY KEY(devolucionID),
    CONSTRAINT contratoDevolucionFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID),
    CONSTRAINT danioDevolucionFK FOREIGN KEY (danioID) REFERENCES DANIO(danioID)
);


-------------------------------------------------------------------------------------------------------------------------------------
--                                                 D M L SISTEMA RENTAS DE AUTOS
-------------------------------------------------------------------------------------------------------------------------------------
--Insertar datos estado_Solicitud
insert into estado_solicitud values (0, 'En proceso');
insert into estado_solicitud values (1, 'Vigente');
insert into estado_solicitud values (2, 'Terminado');

--Daños
Insert into danio values (0, 'Sin daños', 0);
Insert into danio values (1, 'Grado 1', 200);
Insert into danio values (2, 'Grado 2', 400);
Insert into danio values (3, 'Grado 3', 800);
Insert into danio values (4, 'Grado 4', 1600);
Insert into danio values (5, 'Grado 5', 3500);
Insert into danio values (6, 'Daño grave', 4500);


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
INSERT INTO DIRECCION VALUES (2, 8,'Col. Miraflores', 'UNPFM', 230);

--Insertando Sucursal
INSERT INTO SUCURSAL VALUES (1, 'RENTA CAR', 2);

--Insertanto tipos de pago
INSERT INTO TIPO_PAGO VALUES (1, 'Efectivo');
INSERT INTO TIPO_PAGO VALUES (2, 'Tarjeta');


----------------------------------------------------------------------------






