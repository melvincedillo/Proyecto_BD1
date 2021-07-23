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
--Procedimiento para actualizar empleado
--Procedimiento para insertar empleado
create or replace procedure insert_empleado(nb VARCHAR,pn VARCHAR, sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, sld FLOAT,he FLOAT,fi DATE, sex VARCHAR, sc INT)
    as
    begin
        insert into empleado (nombre,p_nombre, s_nombre,p_apellido,s_apellido,identidad,sueldo,horasextras,fecha_ingreso,sexo,sucursalid) 
        values (nb, pn, sn, pa, sa, tid, sld, he, fi, sex, sc);
    end;
    


