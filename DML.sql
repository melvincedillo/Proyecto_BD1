-- DML DE LA BASE DE DATOS RENTADORA --

-- Departamentos
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

--Municipios
INSERT INTO MUNICIPIO VALUES(1,'La Ceiba', 1);
INSERT INTO MUNICIPIO VALUES(3,'Tela', 1);
INSERT INTO MUNICIPIO VALUES(2,'Jutiapa', 1);
INSERT INTO MUNICIPIO VALUES(4,'Trujillo', 2);
INSERT INTO MUNICIPIO VALUES(5,'Balfate', 2);
INSERT INTO MUNICIPIO VALUES(6,'Iriona', 2);
INSERT INTO MUNICIPIO VALUES(7,'Comayagua', 3);
INSERT INTO MUNICIPIO VALUES(8,'Ajuterique', 3);
INSERT INTO MUNICIPIO VALUES(9,'El Rosario', 3);

--Direcciones
INSERT INTO DIRECCION (municipioid, direccion) VALUES (1, 'Col. Los Andes');
INSERT INTO DIRECCION (municipioid, direccion) VALUES (3, 'Telamar');

--Sucursales
INSERT INTO SUCURSAL VALUES (1, 'RENTA CAR', 10);
INSERT INTO SUCURSAL VALUES (2, 'ALAMO', 34);
INSERT INTO SUCURSAL VALUES (3, 'HERTZ', 35);

--Empleados
INSERT INTO EMPLEADO(nombre, p_nombre,s_nombre,p_apellido,s_apellido,identidad,sueldo, horasextras,fecha_ingreso,sexo,sucursalid) VALUES
('Sofia Videa','Sofia','Gineth','Valladares','Videa','0801200003105',40000,12,DATE'2021-12-23','FEMENINO',1);
INSERT INTO EMPLEADO(nombre, p_nombre,s_nombre,p_apellido,s_apellido,identidad,sueldo, horasextras,fecha_ingreso,sexo,sucursalid) VALUES
('Melvin Cedillo','Melvin','Arturo','Cedillo','Rodriguez','0801198003105',20000,10,DATE'2020-12-23','MASCULINO',1);

--Insertando datos Version
INSERT INTO VERSION VALUES(1,'JAPONES');
INSERT INTO VERSION VALUES(2,'AMERICANO');
INSERT INTO VERSION VALUES(3,'CANADINSE');
INSERT INTO VERSION VALUES(4,'UROPERO');
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

--Insertando en tabla marca
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

--Insertando tabla combustible
INSERT INTO COMBUSTIBLE VALUES(1,'Gasolina');
INSERT INTO COMBUSTIBLE VALUES(2,'Diesel');

--Insertando tabla tipo_vehiculo
INSERT INTO TIPO_VEHICULO VALUES(1,'2 cilindros');
INSERT INTO TIPO_VEHICULO VALUES(2,'3 cilindros');
INSERT INTO TIPO_VEHICULO VALUES(3,'4 cilindros');
INSERT INTO TIPO_VEHICULO VALUES (4,'6 cilindros'); 
INSERT INTO TIPO_VEHICULO VALUES (5,'8 cilindros');

--Insertando tabla estado
INSERT INTO ESTADO VALUES(1,'Disponible');
INSERT INTO ESTADO VALUES(2,'Rentado');
INSERT INTO ESTADO VALUES(3,'En Mantenimiento');

--Insertando vehiculos
INSERT INTO VEHICULO (placa,fecha_adquisicion,costo_vehiculo,combustibleID, modeloID, marcaID, colorID, tipo_vehiculoid,versionid,estadoid,seguro)
VALUES ('hurj784', DATE'2021-08-09', 2500, 1, 1, 1, 1, 1, 1, 1, 5000);
INSERT INTO VEHICULO (placa,fecha_adquisicion,costo_vehiculo,combustibleID, modeloID, marcaID, colorID, tipo_vehiculoid,versionid,estadoid,seguro)
VALUES('rg43gb3', DATE'2021-08-10', 3000, 2, 2, 3, 2, 2, 2, 1, 6000);
INSERT INTO VEHICULO(placa,fecha_adquisicion,costo_vehiculo,combustibleID, modeloID, marcaID, colorID, tipo_vehiculoid,versionid,estadoid,seguro)
VALUES ('8k9hn49', DATE'2021-09-30', 4400, 2, 3, 3, 3, 3, 3, 1, 3902);
INSERT INTO VEHICULO (placa,fecha_adquisicion,costo_vehiculo,combustibleID, modeloID, marcaID, colorID, tipo_vehiculoid,versionid,estadoid,seguro)
VALUES('ag6j8m9', DATE'2021-10-23', 5500, 1, 4, 4, 4, 4, 4, 1, 8732);

