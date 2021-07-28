-- DDL DE LA BASE DE DATOS RENTADORA --

create table DEPARTAMENTO(
    departamentoID int,
    departamento varchar(20) not null,
    CONSTRAINT departamentoPK PRIMARY KEY(departamentoID)
);

CREATE TABLE MUNICIPIO(
	municipioID INT ,
	municipio VARCHAR(20) NOT NULL,
	departamentoID int,
	CONSTRAINT municipioPK PRIMARY KEY (municipioID),
	CONSTRAINT departamentoIDFK FOREIGN KEY(departamentoID) REFERENCES DEPARTAMENTO(departamentoID)
);

CREATE TABLE DIRECCION(
    direccionID INT,
	municipioID INT,
	departamentoID INT,
    direccion VARCHAR(200),
    CONSTRAINT direccionPK PRIMARY KEY (direccionID),
	CONSTRAINT municipioFK FOREIGN KEY (municipioID) REFERENCES MUNICIPIO (municipioID),
	CONSTRAINT departamentoFK FOREIGN KEY (departamentoID) REFERENCES DEPARTAMENTO (departamentoID)
);

CREATE TABLE TIPO_RENTA(
	tipo_rentaID INT,
	costo_renta INT NOT NULL,
	tipo_renta VARCHAR(20) NOT NULL,
	CONSTRAINT tipo_rentaPK PRIMARY KEY (tipo_rentaID)
);

create table DANIO(
    danioID int,
    danio varchar(20) not null,
    costo float not null,
    CONSTRAINT danioPK PRIMARY KEY(danioID)
); 

CREATE TABLE RECIBIR(
	recibirID INT,
    direccionID INT,
	fecha DATE NOT NULL,
	CONSTRAINT devolucionPK PRIMARY KEY (recibirID),
    CONSTRAINT direccionEntregaPK FOREIGN KEY (direccionID) REFERENCES DIRECCION(direccionID)
);

CREATE TABLE ENTREGAR(
	entregarID INT, 
    direccionID INT,
	fecha DATE,
	CONSTRAINT entregarPK  PRIMARY KEY (entregarID),
    CONSTRAINT direccionDevolucionPK FOREIGN KEY (direccionID) REFERENCES DIRECCION(direccionID)
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
    identidad varchar(20) not null,
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
    placa varchar(20) not null,
    fecha_adquisicion date not null,
    costo_vehiculo float not null,
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
	identidad VARCHAR(20) NOT NULL,
	rtn VARCHAR(20) NOT NULL,
	sexo VARCHAR(15),
	direccionID INT NOT NULL,
	CONSTRAINT clientePK PRIMARY KEY (clienteID),
    CONSTRAINT direccionClienteFK FOREIGN KEY (direccionID) REFERENCES DIRECCION (direccionID)
);

CREATE TABLE TELEFONOxCLIENTE(
	clienteID INT NOT NULL,
	telefono VARCHAR (20) NOT NULL,
	CONSTRAINT clienteFK FOREIGN KEY (clienteID) REFERENCES  CLIENTE (clienteID),
	CONSTRAINT telefono UNIQUE (telefono)
);

CREATE TABLE TELEFONOxEMPLEADO(
	empleadoID INT NOT NULL,
	telefono VARCHAR(20) NOT NULL,
	CONSTRAINT telefonoxempleadoFK FOREIGN KEY (empleadoID) REFERENCES EMPLEADO (empleadoID),
	CONSTRAINT telefonoEmpleado UNIQUE (telefono)
);

CREATE TABLE TELEFONOxSUCURSAL(
	sucursalID INT NOT NULL,
	telefono VARCHAR(20) NOT NULL,
	CONSTRAINT sucursalTelFK FOREIGN KEY (sucursalID) REFERENCES SUCURSAL (sucursalID),
	CONSTRAINT telefonoSucursal UNIQUE (telefono)
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

create table SOLICITUD(
    solicitudID int,
    fecha_solicitud date not null,
    tipo_rentaID INT not null,
    subtotal float not null,
    sucursalID int not null,
    vehiculoID int not null,
    entregarID int not null,
    recibirID int not null,
    clienteID int not null,
    CONSTRAINT solicitudPK PRIMARY KEY(solicitudID),
    CONSTRAINT sucursalSolicitudPK foreign key(sucursalID) references SUCURSAL(sucursalID),
    CONSTRAINT vehiculoSolicitudPK foreign key(vehiculoID) references VEHICULO(vehiculoID),
    CONSTRAINT entregarSolicitudPK foreign key(entregarID) references ENTREGAR(entregarID),
    CONSTRAINT recibirSolicitudPK foreign key(recibirID) references RECIBIR(recibirID),
    CONSTRAINT clienteSolicitudPK foreign key(clienteID) references CLIENTE(clienteID),
    CONSTRAINT rentaSolicitudPK foreign key(tipo_rentaID) references TIPO_RENTA(tipo_rentaID)
);

create table CONTRATO(
    contratoID int,
    fecha date not null,
    subtotal float not null,
    iva int not null,
    total float not null,
    solicitudID int not null,
    CONSTRAINT contratoPK PRIMARY KEY(contratoID),
    CONSTRAINT solicitudContratoFK foreign key(solicitudID) references SOLICITUD(solicitudID)
);

create table TIPO_PAGO(
    tipo_PagoID int,
    tipo_Pago varchar(20) not null,
    CONSTRAINT tipo_PagoPK PRIMARY KEY(tipo_pagoID)
); 

CREATE TABLE PAGO(
	pagoID INT,
	total_pagado FLOAT NOT NULL,
	cambio FLOAT NOT NULL,
	tipo_pagoID INT,
    contratoID INT,
	CONSTRAINT pagoPK PRIMARY KEY (pagoID),
	CONSTRAINT tipo_pagoFK FOREIGN KEY (tipo_pagoID) REFERENCES TIPO_PAGO (tipo_pagoID),
    CONSTRAINT contrato_pagoFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID)
);

CREATE TABLE DEVOLUCION(
    devolucionID INT,
    contratoID INT,
    direccionID INT,
    fecha DATE,
    CONSTRAINT devPK PRIMARY KEY(devolucionID),
    CONSTRAINT contratoDevolucionFK FOREIGN KEY (contratoID) REFERENCES CONTRATO(contratoID),
    CONSTRAINT direccionDFK FOREIGN KEY (direccionID) REFERENCES DIRECCION(direccionID)
);

CREATE TABLE DEVOLUCIONxDANIOS(
    devolucionID INT,
    danioID INT,
    CONSTRAINT devolucionFK FOREIGN KEY (devolucionID) REFERENCES DEVOLUCION(devolucionID),
    CONSTRAINT danioFK FOREIGN KEY (danioID) REFERENCES DANIO(danioID)
);
