
--Procedimiento para seleccionar Autos

create or replace procedure select_vehiculos(vehiculo out SYS_REFCURSOR)
    as
    begin
        open vehiculo for
            SELECT 
                v.vehiculoID AS ID, 
                v.placa,
                m.modelo AS Modelo,
                ma.marca,
                c.color AS Color,
                ve.version,
                co.combustible,
                tv.tipo_vehiculo AS "Tipo",
                o.pais AS "Pais Origen",
                v.costo_vehiculo AS "Costo Adquisicion",
                v.costo_renta AS "Costo Renta",
                e.estado AS Estado
            FROM 
                vehiculo v
            INNER JOIN Modelo m ON m.modeloID=v.modeloID
            INNER JOIN Color c ON c.colorID=v.colorID
            INNER JOIN Estado e ON e.estadoID=v.estadoID
            INNER JOIN marca ma ON ma.marcaid =  v.marcaid
            INNER JOIN origen o ON o.origenid =  ma.origenid
            INNER JOIN combustible co ON co.combustibleid = v.combustibleid
            INNER JOIN version ve ON ve.versionid = v.versionid
            INNER JOIN tipo_vehiculo tv ON tv.tipo_vehiculoid = v.tipo_vehiculoid;
        end;
        
        
--Procedimiento para elegir Autos

create or replace procedure elegir_vehiculos(vehiculo out SYS_REFCURSOR)
    as
    begin
        open vehiculo for
            SELECT 
                v.vehiculoID AS ID, 
                v.placa,
                m.modelo AS Modelo,
                ma.marca,
                c.color AS Color,
                ve.version,
                co.combustible,
                tv.tipo_vehiculo AS "Tipo",
                o.pais AS "Pais Origen",
                v.costo_vehiculo AS "Costo Adquisicion",
                v.costo_renta AS "Costo Renta"
            FROM 
                vehiculo v
            INNER JOIN Modelo m ON m.modeloID=v.modeloID
            INNER JOIN Color c ON c.colorID=v.colorID
            INNER JOIN marca ma ON ma.marcaid =  v.marcaid
            INNER JOIN origen o ON o.origenid =  ma.origenid
            INNER JOIN combustible co ON co.combustibleid = v.combustibleid
            INNER JOIN version ve ON ve.versionid = v.versionid
            INNER JOIN tipo_vehiculo tv ON tv.tipo_vehiculoid = v.tipo_vehiculoid
            
            WHERE v.estadoid = 0;
        end;

--Procedimiento para eliminar Auto

create or replace procedure delete_vehiculo (idV rentadora.vehiculo.vehiculoid%TYPE)
    as
    begin
        delete from rentadora.vehiculo where vehiculoid = idV;
    end;

--Procedimiento para actualizar auto
create or replace procedure update_vehiculo(placa VARCHAR,fecha DATE, costo_a FLOAT, costo_r FLOAT, cb INT, modelo INT,mar INT, color INT, tv INT, vers INT, est INT, seguro FLOAT, idV INT)
    as
        vPLACA varchar(30) := placa;
        vFECHA date := fecha;
        vCOSTO_A float := costo_a;
        vCOSTO_R float := costo_r;
        vCB int := cb;
        vModelo int := modelo;
        vMAR int := mar;
        vCOLOR int := color;
        vTV int:= tv;
        vVers int := vers;
        vEST int := est;
        vSEGURO float := seguro;
        vIDV int := idV;
    begin
        update vehiculo set placa=vPLACA, fecha_adquisicion=vFECHA,costo_vehiculo=vCOSTO_A, combustibleid=vCB, modeloid=vModelo, marcaid=vMar,
        colorid=vCOLOR, tipo_vehiculoid=vTV,versionid=vVers,estadoid=vEST,seguro=vSEGURO, costo_renta = vcosto_r where vehiculoid = vIDV;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            null;
    end update_vehiculo;


--Procedimiento para insertar auto

create or replace procedure insert_vehiculos(plac VARCHAR,fecha DATE, costo_a FLOAT, costo_r float, cb INT, modelo INT,mar INT, color INT, tv INT, vers INT, est INT, segur FLOAT)
    as
    begin
        insert into vehiculo (placa,fecha_adquisicion,costo_vehiculo, costo_renta,combustibleid,modeloid,marcaid,colorid,tipo_vehiculoid,versionid,estadoid,seguro) 
        values (plac,fecha,costo_a, costo_r,cb,modelo,mar,color,tv,vers,est,segur);
    end;