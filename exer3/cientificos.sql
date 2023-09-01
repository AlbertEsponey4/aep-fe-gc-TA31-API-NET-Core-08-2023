create database cientificos;
use cientificos;

create table cientificos(
	DNI varchar(8) primary key,
    NomApels varchar(255)
);

create table proyectos(
	id char(4) primary key,
    Nombre varchar(255),
    Horas int
);

create table asignado_a(
	Cientifico varchar(8),
    Proyecto char(4),
    primary key(Cientifico, Proyecto),
    constraint Cientifico_fk foreign key (Cientifico) references cientificos(DNI),
    constraint Proyecto_fk foreign key (Proyecto) references proyectos(id)
);

INSERT INTO cientificos (DNI, NomApels)
VALUES
    ('12345678', 'Juan Pérez'),1
    ('23456789', 'María Rodríguez'),
    ('34567890', 'Carlos López'),
    ('45678901', 'Ana Martínez'),
    ('56789012', 'Luis García');

INSERT INTO proyectos (id, Nombre, Horas)
VALUES
    ('P001', 'Proyecto A', 100),
    ('P002', 'Proyecto B', 150),
    ('P003', 'Proyecto C', 200);
    
    INSERT INTO asignado_a (Cientifico, Proyecto)
VALUES
    ('12345678', 'P001'),
    ('12345678', 'P002'),
    ('23456789', 'P002'),
    ('23456789', 'P003'),
    ('34567890', 'P001'),
    ('34567890', 'P003');



