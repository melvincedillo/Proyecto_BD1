--PROCEDIMIENTO SELECCIONAR SOLICITUD
create or replace procedure select_solicitud(registros out SYS_REFCURSOR)
    as
    begin
        open registros for 
            select 
                s.solicitudid as NUMERO,
                s.fecha_solicitud as FECHA,
                (c.p_nombre||' '||c.p_apellido) as CLIENTE,
                c.identidad AS "ID Cliente",
                e.nombre as EMPLEADO,
                (m.modelo||' '||ma.marca) AS VEHICULO,
                s.subtotal as TOTAL,
                s.vehiculoid,
                s.fecharinicio,
                s.fechafin
            from 
                solicitud s 
                inner join cliente c on s.clienteid = c.clienteid
                inner join vehiculo ve on ve.vehiculoid = s.vehiculoid
                inner join empleado e on e.empleadoid = s.empleadoid
                inner join modelo m on m.modeloid = ve.modeloid
                inner join marca ma on ma.marcaid = ve.marcaid
            where 
                 s.estadoid = 0;
        end;
        
--PROCEDIMIENTO ELIMINAR SOLICITUD
create or replace procedure delete_solicitud(idS int)
    as
    begin
        delete from solicitud where solicitudid = idS;
    end;

--PROCEDIMIENTO CREAR SOLICITUD
create or replace procedure insertar_solicitud(fechas date, subt float, sucursal int, cliente int, empleado int, vehiculo int, fechai date, fechaf date,seguro varchar)
    as
    begin
        insert into solicitud (fecha_solicitud, fecharinicio, fechafin, subtotal, vehiculoid, clienteid, sucursalid, empleadoid, seguro,estadoid) 
        values(fechas, fechai, fechaf, subt, vehiculo, cliente, sucursal, empleado, seguro,0);
    end;
    
    
--PROCEDIMIENTO ACTUALIZAR SOLICITUD
create or replace procedure update_solicitud(idS int, fechai date, fechaf date, vehiculo int, subt float,segur varchar)
as
begin
    update solicitud set fecharinicio = fechai, fechafin = fechaf, vehiculoid = vehiculo, subtotal = subt ,seguro=segur where solicitudid = idS;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        null;
end;