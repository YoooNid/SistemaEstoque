USE [RmSoft]

CREATE TABLE funcionario(
	ID_Usuario int IDENTITY (1,1) primary key NOT NULL,
	[Codigo] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Dt_nascimento] [datetime],
	[Sexo] [char](1) NOT NULL,
	[RG] [int] NULL,
	[CPF] [int] NOT NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](25) NULL,
	[Cidade] [varchar](25) NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [char](6) NULL,
	[OBS] [varchar](200) NULL,
)

CREATE TABLE Produtos
(
ID_Produto int IDENTITY (1,1) primary key not null,
[Codigo] [int] NOT NULL,
Descricao varchar(50),
Preco int
)


insert into produtos (descricao, preco) values  ('produto teste','4.19')


insert into funcionario (Codigo,Nome,Dt_nascimento, Sexo,RG,CPF,Endereco,Bairro,Cidade,Usuario,Senha,OBS)
values 
( '0001', 'supervisor','','M','255411','40291203','rua antiga','terra preta','mairipora','a','a','primeiro usuario do sistema');

insert into funcionario (Codigo,Nome,Dt_nascimento, Sexo,RG,CPF,Endereco,Bairro,Cidade,Usuario,Senha,OBS)
values 
( '0002', 'rodrigo' , '' , 'M' , '123456' , '12324' , 'rua antonio rondina' , 'terra preta' , 'mairipora' , 'supervisor' , 'mouse' , 'primeiro usuario do sistema');


