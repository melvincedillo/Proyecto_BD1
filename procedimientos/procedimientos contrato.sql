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
