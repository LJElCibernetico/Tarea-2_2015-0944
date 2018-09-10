create database Proyecto;
use Proyecto;

CREATE TABLE Usuarios (
  IdUsuario int primary key identity(1,1),
  Username varchar(max),
  Password varchar(max),
  Fecha Date,
  Nombre varchar(max),
  Comentario varchar(max)
);

insert into Usuarios values('lj','0515','04-02-2018','Luis Jose','Normal User');
select * from Usuarios;