--Procedimiento para mostrar clientes

create or replace procedure select_clientes(registros out SYS_REFCURSOR)
    as
    begin
        open registros for
            SELECT 
                clienteID AS ID, 
                (p_nombre||' '||s_nombre||' '||p_apellido||' '||s_apellido) AS Nombre,
                identidad,
                rtn,
                sexo,
                direccionid
            FROM 
                cliente
            ORDER BY 
                p_apellido;
        end;
        
--Procedimiento insertar direccion
create or replace procedure insert_direccion(idM int, dir VARCHAR2, idDir out int)
    as
    begin
        insert into direccion (municipioid, direccion) values (idM, dir);
        SELECT DIRECCION_SECUENCIA.currval into iddir from dual;
    end;
    
--Procedimiento insertar cliente
create or replace procedure insert_cliente(pn VARCHAR, sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, rtn VARCHAR, sex VARCHAR, dir int)
    as
    begin
        insert into cliente (p_nombre, s_nombre,p_apellido,s_apellido,identidad,rtn,sexo,direccionid) 
        values (pn, sn, pa, sa, tid, rtn,sex,dir);
    end;
    
--Eliminar cliente
create or replace procedure delete_cliente (idC rentadora.cliente.clienteid%TYPE, idDir rentadora.direccion.direccionid%Type)
    as
    begin
        delete from rentadora.cliente where clienteid = idC;
        delete from rentadora.direccion where direccionid = idDir;
    end;

--Actualizar cliente
create or replace procedure update_cliente(pn VARCHAR, sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, rtnC VARCHAR, sex VARCHAR2, idC int)
    as
        vPN varchar(20) := pn;
        vSN varchar(20) := sn;
        vPA varchar(20) := pa;
        vSA varchar(20) := sa;
        vTID varchar(20) := tid;
        vRTNC varchar(20) := rtnC;
        vSEX varchar2(15) := sex;
        vIDC int := idC;
    begin
        update cliente set p_nombre = vPN, s_nombre = vSN, p_apellido = vPA, s_apellido = vSA, identidad = vTID, rtn = vRTNC, sexo = vSEX where clienteid = vIDC;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            null;
    end update_cliente;
    
--Actualizar direccion
create or replace procedure update_direccion(idDir int, idM int, dir varchar2)
as
begin
    update direccion set municipioid = idM, direccion = dir where direccionid = idDir;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        null;
end update_direccion;

--Procedimiento para seleccionar empleado
create or replace procedure select_empleados(empleado out SYS_REFCURSOR)
    as
    begin
        open empleado for
            SELECT 
                empleadoID AS ID, 
                nombre AS Nombre,
                identidad AS Identidad,
                sueldo AS Sueldo,
                fecha_ingreso AS Fecha_Ingresado
            FROM 
                empleado;
        end;
        
-- Procedimiento para eliminar empleado

create or replace procedure delete_empleado (idE rentadora.empleado.empleadoid%TYPE)
    as
    begin
        delete from rentadora.empleado where empleadoid = idE;
    end;

--Procedimiento para actualizar empleado

create or replace procedure update_empleado(nb VARCHAR,pn VARCHAR, 
sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, sld FLOAT,he FLOAT,fi DATE, sex VARCHAR, sc INT, idE INT)
    as
        vNE varchar(30) := nb;
        vPN varchar(20) := pn;
        vSN varchar(20) := sn;
        vPA varchar(20) := pa;
        vSA varchar(20) := sa;
        vTID varchar(20) := tid;
        VSLD float := sld;
        VHE float := he;
        VFI date := fi;
        vSEX varchar2(15) := sex;
        vSC int := sc;
        vIDE int := idE;
    begin
        update empleado set nombre=vNE, p_nombre = vPN, s_nombre = vSN, p_apellido = vPA, s_apellido = vSA, identidad = vTID, sueldo = vSLD,horasextras=vHE,fecha_ingreso=vFI, sexo = vSEX, sucursalid= vSC where empleadoid = vIDE;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            null;
    end update_empleado;

--Procedimiento para insertar empleado
create or replace procedure insert_empleado(nb VARCHAR,pn VARCHAR, 
sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, sld FLOAT,he FLOAT,fi DATE, sex VARCHAR, sc INT)
    as
    begin
        insert into empleado (nombre,p_nombre, s_nombre,p_apellido,s_apellido,identidad,sueldo,horasextras,fecha_ingreso,sexo,sucursalid) 
        values (nb, pn, sn, pa, sa, tid, sld, he, fi, sex, sc);
    end;


--Procedimiento para seleccionar Autos

create or replace procedure select_vehiculos(vehiculo out SYS_REFCURSOR)
    as
    begin
        open vehiculo for
            SELECT 
                v.vehiculoID AS ID, 
                v.placa,
                v.costo_vehiculo AS Costo,
                m.modelo AS Modelo,
                c.color AS Color,
                e.estado AS Estado
            FROM 
                vehiculo v
            INNER JOIN Modelo m ON m.modeloID=v.modeloID
            INNER JOIN Color c ON c.colorID=v.colorID
            INNER JOIN Estado e ON e.estadoID=v.estadoID;
        end;

--Procedimiento para eliminar Auto

create or replace procedure delete_vehiculo (idV rentadora.vehiculo.vehiculoid%TYPE)
    as
    begin
        delete from rentadora.vehiculo where vehiculoid = idV;
    end;

--Procedimiento para actualizar auto

create or replace procedure update_vehiculo(placa VARCHAR,fecha DATE, costo FLOAT, cb INT, modelo INT,mar INT, color INT, tv INT, vers INT, est INT, seguro FLOAT, idV INT)
    as
        vPLACA varchar(30) := placa;
        vFECHA date := fecha;
        vCOSTO float := costo;
        vCB int := cb;
        vModelo int := modelo;
        vMAR int := mar;
        vCOLOR int := color;
        vTV int:= tv;
        vVers int := vers;
        vEST int := est;
        vSEGURO float := seguro;
        vIDV int := idV;
    begin
        update vehiculo set placa=vPLACA, fecha_adquisicion=vFECHA,costo_vehiculo=vCOSTO, combustibleid=vCB, modeloid=vModelo, marcaid=vMar,
        colorid=vCOLOR, tipo_vehiculoid=vTV,versionid=vVers,estadoid=vEST,seguro=vSEGURO where vehiculoid = vIDV;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            null;
    end update_vehiculo;


--Procedimiento para insertar auto

create or replace procedure insert_vehiculos(placa VARCHAR,fecha DATE, costo FLOAT, cb INT, modelo INT,mar INT, color INT, tv INT, vers INT, est INT, seguro FLOAT)
    as
    begin
        insert into vehiculo (placa,fecha_adquisicion,costo_vehiculo,combustibleid,modeloid,marcaid,colorid,tipo_vehiculoid,versionid,estadoid,seguro) 
        values (placa,fecha,costo,cb,modelo,mar,color,tv,vers,est,seguro);
    end;
    


