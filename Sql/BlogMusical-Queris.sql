/********************01-05-2017********************/
Begin
  create database BlogMusical;
  create table Generos
  (
	GeneroId int identity(1,1),
	NombreGenero varchar(30) not null default ''
  );
  insert into Generos
		Values('Rock'),
			  ('Hard Rock'),
			  ('Heavy Metal'),
			  ('Thrash Metal'),
			  ('Progressive Rock'),
			  ('psychedelic Rock');

  Create table usuarios
  (
	UsuarioId int identity(1,1),
	Nickname varchar(8) not null default '',
	Nombres varchar(30) not null default '',
	ApellidoPaterno varchar(30) not null default '',
	ApellidoMaterno varchar(30) not null default '',
	PaisId int  not null default '',
	Correo varchar(35) not null default ''
  );
  create table  Paises
  (
    PaisId int identity(1,1),
	NombrePais varchar(35) not null default ''
  );
END
GO