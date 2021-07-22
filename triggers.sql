create SEQUENCE cliente_secuencia START WITH 10;
create SEQUENCE direccion_secuencia START WITH 10;
create SEQUENCE nice START WITH 10;

--Auto incremental cliente
create or REPLACE TRIGGER cliente_tri
    before insert on cliente
        for EACH row
    begin
        select cliente_secuencia.NEXTVAL
        into :new.clienteid
        from dual;
    end;

--Autoincremental direccion
create or replace trigger direccion_tri
    before insert on direccion
        for EACH row
    begin
        select direccion_secuencia.NEXTVAL
        into :new.direccionid
        from dual;
    end;
