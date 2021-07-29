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
create or replace procedure insert_direccion(idM int, colonia VARCHAR2, callea varchar2, casaa int, idDir out int)
    as
    begin
        insert into direccion (municipioid, col_aldea, calle, casa) values (idM, colonia, callea, casaa);
        SELECT DIRECCION_SECUENCIA.currval into iddir from dual;
    end;
    
--Procedimiento insertar cliente
create or replace procedure insert_cliente(pn VARCHAR, sn VARCHAR, pa VARCHAR, sa VARCHAR, tid VARCHAR, rtn VARCHAR, sex VARCHAR, dir int, idC out int)
    as
    begin
        insert into cliente (p_nombre, s_nombre,p_apellido,s_apellido,identidad,rtn,sexo,direccionid) 
        values (pn, sn, pa, sa, tid, rtn,sex,dir);
        SELECT CLIENTE_SECUENCIA.currval into idC from dual;
    end;
    
--Eliminar cliente
create or replace procedure delete_cliente (idC rentadora.cliente.clienteid%TYPE, idDir rentadora.direccion.direccionid%Type)
    as
    begin
        delete from rentadora.telefonoxcliente where clienteid = idC;
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
create or replace procedure update_direccion(idDir int, idM int, colonia varchar2, cal varchar, cas int)
as
begin
    update direccion set municipioid = idM, col_aldea = colonia, calle = cal, casa = cas where direccionid = idDir;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        null;
end update_direccion;


--PROCEDIMIENTO INSERTAR TELEFONO DE CLIENTE
create or replace procedure insert_tel_cliente(idC int, tel varchar, posT int)
    as
    begin
        insert into telefonoxcliente (telefono, clienteID, pos) values (tel, idC, posT);
    end;

--Procedimiento actualizar telefonos del cliente
create or replace procedure update_tel_cliente (idC int, tel varchar, posT int)
    as
    begin
        update telefonoxcliente set telefono = tel where clienteid = idC and pos = posT;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            null;
    end;
