create database Clients;
use Clients;

create table cliente(
	id int not null auto_increment primary key,
    nombre varchar(250) default null,
    apellido varchar(250) default null,
    direccion varchar(250) default null,
    dni int default null,
    fecha date default null
);

create table videos (
	id int not null auto_increment primary key,
    titulo varchar(250) default null,
    director varchar(250) default null,
    cli_id int default null,
    constraint videos_fk foreign key (cli_id) references cliente(id)
);

insert into cliente (nombre, apellido, direccion, dni, fecha) values
('Juan', 'Perez', 'Calle 123', 123456789, '2023-01-15'),
('Maria', 'Gomez', 'Avenida 456', 987654321, '2023-02-20'),
('Luis', 'Gonzalez', 'Carrera 789', 555555555, '2023-03-10');

INSERT INTO videos (titulo, director, cli_id)
VALUES
    ('Pelicula 1', 'Director 1', 1),
    ('Pelicula 2', 'Director 2', 2),
    ('Pelicula 3', 'Director 3', 3);