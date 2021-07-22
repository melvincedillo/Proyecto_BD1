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
                sexo
            FROM 
                cliente
            ORDER BY 
                p_apellido;
        end;
        
--Procedimiento insertar direccion
create or replace procedure insert_direccion(idM int, dir VARCHAR2)
    as
    begin
        insert into direccion (municipioid, direccion) values (idM, dir);
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
    

