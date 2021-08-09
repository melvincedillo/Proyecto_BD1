--crea un contrato
create or replace procedure insert_contrato(idCo int, fech date, subt float, ivac float, totalc float, idS int)
    as
    begin
        insert into contrato (contratoid, fecha, subtotal, iva, total, solicitudid) values 
        (idCo, fech, subt, ivac, totalc, idS);

        update solicitud set estadoid = 1 where solicitudid = idS;
    EXCEPTION
    WHEN NO_DATA_FOUND THEN
        null;
    end;


--SELECCIONA LOS CONTRATOS
create or replace procedure select_contrato(registros out sys_refcursor)
    as
    begin
        open registros for
            select c.contratoid as "N°", 
                c.fecha as "Fecha emision",
                (cli.p_nombre || ' ' || cli.p_apellido) as "Cliente",
                v.placa as "Placa",
                (mo.modelo || ' ' || ma.marca) as "Vehiculo",
                c.total as "Total", 
                es.estado as "Estado" 
            from rentadora.contrato c 
                inner join rentadora.solicitud s on c.solicitudid = s.solicitudid
                inner join rentadora.estado_solicitud es on es.estadoid = s.estadoid
                inner join rentadora.cliente cli on cli.clienteid = s.clienteid
                inner join rentadora.vehiculo v on v.vehiculoid = s.vehiculoid
                inner join rentadora.modelo mo on mo.modeloid = v.modeloid
                inner join rentadora.marca ma on ma.marcaid = v.marcaid
            where
                s.estadoid = 1 OR s.estadoid = 2;
    end;