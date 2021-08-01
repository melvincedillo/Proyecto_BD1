create SEQUENCE cliente_secuencia START WITH 10;
create SEQUENCE direccion_secuencia START WITH 10;
create SEQUENCE empleado_secuencia START WITH 10;
create SEQUENCE vehiculo_secuencia START WITH 10;
create SEQUENCE solicitud_secuencia START WITH 100;


--Auto incremental cliente
create or REPLACE TRIGGER cliente_tri
    before insert on cliente
        for EACH row
    begin
        select cliente_secuencia.NEXTVAL
        into :new.clienteid
        from dual;
    end cliente_tri;

--Autoincremental direccion
create or replace trigger direccion_tri
    before insert on direccion
        for EACH row
    begin
        select direccion_secuencia.NEXTVAL
        into :new.direccionid
        from dual;
    end direccion_tri;


--AutoIncremenral empleado
create or replace trigger empleado_tri
    before insert on empleado
        for EACH row
    begin
        select empleado_secuencia.NEXTVAL
        into :new.empleadoid
        from dual;
    end empleado_tri;

--Autoincremental Auto
create or replace trigger vehiculo_tri
    before insert on vehiculo
        for EACH row
    begin
        select vehiculo_secuencia.NEXTVAL
        into :new.vehiculoid
        from dual;
    end vehiculo_tri;
    

--Autoincremental solicitud
create or replace trigger solicitud_tri
    before insert on solicitud
        for EACH row
    begin
        select SOLICITUD_SECUENCIA.nextval
        into :new.solicitudid
        from dual;
    end solicitud_tri;
    
