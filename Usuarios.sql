
--Ususario donde se guardar la base de datos
create role adminBD;

grant 
    create any table, 
    alter any table, 
    update any table, 
    insert any table, 
    select any table, 
    delete any table, 
    drop any table,
    execute any procedure,
    create any procedure,
    alter any procedure,
    drop any procedure,
    create session,
    alter any trigger, 
    alter any SEQUENCE, 
    create any TRIGGER, 
    create any SEQUENCE, 
    drop any TRIGGER, 
    DROP any SEQUENCE 
to adminBD;

create user rentadora identified by iselias default tablespace system quota unlimited on system;
grant adminBD to rentadora;

--rol para usuarios de lectura-escritura
create role escritura;
grant 
    update any table, 
    insert any table, 
    select any table,  
    delete any table, 
    execute any procedure,
    create session,
    alter any trigger, 
    alter any SEQUENCE,
    create any TRIGGER
to escritura;

--rol para usuarios de solo lectura
create role lectura;
grant
    select any table, 
    execute any procedure,
    create session
to lectura;

--NOTA: estos privilegios se pueden modificar segun avanzemos en el proyecto