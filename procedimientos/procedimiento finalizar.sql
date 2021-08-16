--PROCEDIMIENTO INSERTAR DEVOLUCION
create or replace procedure insert_devolucion(idC_D int, fechad date)
    as
    begin
        insert into devolucion (devolucionid, contratoid, fecha, danioid) values (idC_D, idC_D, fechad, 0);
    end;

/*
--PROCEDIMIENTO INSERTAR DAÑO
create or replace procedure insert_danios(daño varchar, precio float, idD int, idDa out int)
    as
    begin
        insert into danio(danio, costo) values (daño, precio);
        select danio_secuencia.currval into idDa from dual;
        insert into devolucionxdanios (devolucionid, danioid) values (idD, danio_secuencia.currval);
    end;
    
--PROCEDIMIENTO ELIMINAR DAÑO
create or replace procedure delete_danios(idD int, idDa int)
    as
    begin
        delete devolucionxdanios where devolucionid = idD AND danioid = idDa;
        delete danio where danioid = idDa;
    end;
    
    delete from devolucion;
    
--PROCEDIMIENTO MOSTRAR DAÑOS
create or replace procedure select_daño(idD int, registros out SYS_REFCURSOR)
    as
    begin
        open registros for 
            select dd.danioid, d.danio as "Descripcion", d.costo as "Costo" 
            from devolucionxdanios dd inner join danio d on dd.danioid = d.danioid 
            where dd.devolucionid = idD;
        end;
*/