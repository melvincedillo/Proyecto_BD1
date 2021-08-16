--PROCEDIMIENTO INSERTAR DEVOLUCION
create or replace procedure insert_devolucion(idC_D int, fechad date)
    as
    begin
        insert into devolucion (devolucionid, contratoid, fecha, danioid) values (idC_D, idC_D, fechad, 0);
    end;
