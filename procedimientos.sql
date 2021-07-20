--Procedimiento para mostrar clientes

create or replace procedure clientes(registros out SYS_REFCURSOR)
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
                cliente;
        end;