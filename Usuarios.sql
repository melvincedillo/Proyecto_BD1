
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
    create session
to adminDB;

create user rentadora identified by iselias default tablespace system quota unlimited on system;

--rol para usuarios de lectura-escritura
grant 
    update any table, 
    insert any table, 
    select any table,  
    delete any table, 
    execute any procedure,
    create session
to escritura;

--rol para usuarios de solo lectura
grant
    select any table, 
    execute any procedure,
    create session
to lectura;

--NOTA: estos privilegios se pueden modificar segun avanzemos en el proyecto