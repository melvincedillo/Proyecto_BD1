
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

