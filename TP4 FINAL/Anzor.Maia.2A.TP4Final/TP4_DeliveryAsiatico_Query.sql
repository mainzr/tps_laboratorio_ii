--Creacion de la base de datos
CREATE DATABASE Delivery_Comida_Asiatica;
GO

use Delivery_Comida_Asiatica;
GO


CREATE TABLE Repartidores(
ID_REPARTIDOR int identity not null,
NOMBRE varchar(50) not null,
APELLIDO varchar(50) not null,
SEXO varchar(50) not null,
NUMERO_DE_CONTACTO varchar(50) not null,
ESTADO_REPARTIDOR varchar(50) not null,
);
GO

--Agregar clientes hardcodeados de prueba
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Gideon', 'Rozenzweig', 'M', '8059422133', 'Activo');
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Gav', 'Sherratt', 'M', '4814993053', 'Activo');
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Dennet', 'Currey', 'F', '6156759723', 'Inactico');
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Clara', 'Amner', 'F', '9754199269', 'Activo');
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Doy', 'Lumber', 'M', '1414252707', 'Inactivo');
insert into Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) values ('Trey', 'Vanelli', 'M', '2167432529', 'Activo');

--obtener * datos esto trae todos los datos que haya en la base de datos
SELECT * FROM Repartidores;


