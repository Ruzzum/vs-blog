/********************01-05-2017********************/
create database blog_musical;
go

create table generos
(
	id_genero int identity(1,1) constraint [PK_genero] primary key,
	nombre varchar(64)
);
go

insert into generos
	   values('Rock'),
			 ('Hard Rock'),
			 ('Heavy Metal'),
			 ('Thrash Metal'),
			 ('Progressive Rock'),
			 ('Psychedelic Rock');
go

create table pais
(
	id_pais int identity(1,1) constraint [PK_pais] primary key,
	nombre varchar(32)
);
go

create table usuarios
(
	id_usuario int identity(1,1) constraint [PK_usuario] primary key,
	usuario varchar(12),
	contrasena varchar(12),
	nombre varchar(32),
	apellido_paterno varchar(32),
	apellido_materno varchar(32),
	id_pais int,
	e_mail varchar(32)
);
go

alter table usuarios add constraint [FK_usuario_pais] foreign key (id_pais) references pais (id_pais);
go

