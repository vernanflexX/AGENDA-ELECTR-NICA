use agenda
create table persona (
Id INT PRIMARY KEY NOT NULL,
NOMBRE VARCHAR(40) NOT NULL,
APELLIDO VARCHAR(40) NOT NULL,
FECHA_DE_NACIMIENTO VARCHAR(40),
DIRECCION VARCHAR(40),
GENERO VARCHAR(40) ,
ESTADO_CIVIL VARCHAR(40),
MOVIL VARCHAR(40),
TELEFONO VARCHAR(40),
CORREO_ELECTRONICO VARCHAR(40)
);

SELECT * FROM persona
update persona set DIRECCION= '27 de febrero' where Id=01
delete from persona where Id=2
insert into persona values('01','Juan','Perez','11/10/90','Ensanche la fe','Masculino','Soltero','8092503467','0000','juan@com')