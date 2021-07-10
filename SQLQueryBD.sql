Create table usuario
(
u_Id int primary key identity not null,
u_Nome nvarchar(100) not null,
u_UsuarioNome nvarchar(40) not null,
u_Senha varchar(40) not null,
u_Telefone varchar(20) not null,
u_Email nvarchar(100) not null,
u_Status tinyint not null,
)


Create procedure st_insertusuario
@Nome nvarchar(100) ,
@UsuarioNome nvarchar(40) ,
@Senha varchar(40) ,
@Telefone varchar(20) ,
@Email nvarchar(100) ,
@Status tinyint
as
insert into usuario values (@Nome,@UsuarioNome,@Senha,@Telefone,@Email,@Status)


Create table funcao
(
f_Id tinyint not null identity primary key,
f_Nome nvarchar(100) not null,
f_Status tinyint not null
)


alter table usuario
add u_funcaoID tinyint not null foreign key references funcao(f_Id) on update cascade on delete cascade



Create table categorias
(
cat_Id tinyint not null identity primary key,
cat_Nome nvarchar(100) not null,
cat_Status tinyint not null
)


