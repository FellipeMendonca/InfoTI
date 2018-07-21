--create database Treinamento
--go
drop table PessoaJuridica
go
drop table PessoaFisica
go
create table PessoaJuridica (
	Id int primary key identity(1,1) not null,
	Nome varchar(200) not null,
	Email varchar(200) not null,
	CNPJ char(16)
);
go
create table PessoaFisica (
	Id int primary key identity(1,1) not null,
	Nome varchar(200) not null,
	Email varchar(200) not null,
	CPF char(12)
);
go
INSERT INTO PessoaJuridica values ('SmallTown Armas', 'smatown@outlook.com', '00000001/0001-36')
go
INSERT INTO PessoaJuridica values ('CarliFire', 'clfemp@outlook.com', '00000002/0001-80')
go
INSERT INTO PessoaJuridica values ('OnderWood Peças', 'onderwood@outlook.com', '00002145/0001-21')
go
INSERT INTO PessoaJuridica values ('Jiguilion', 'jiguicia@outlook.com', '78791712/0001-63')
go
INSERT INTO PessoaJuridica values ('Midnight Festas', 'midfestas@outlook.com', '92690817/0001-57')
go
INSERT INTO PessoaFisica values ('BRENO DE ALMEIDA FILHO', 'bdafilho@outlook.com', '169429315-78')
go
INSERT INTO PessoaFisica values ('ANTONIO JOSE MARIA FIGUEIRA', 'antoniojmariaf@outlook.com', '697200105-68')
go
INSERT INTO PessoaFisica values ('ANTONIO CANDIDO DE ABREU', 'candidoantonio@outlook.com', '224340701-91')
go
INSERT INTO PessoaFisica values ('CELIA CONCEICAO DE OLIVEIRA', 'celiaoli@outlook.com', '193077628-48')
go
INSERT INTO PessoaFisica values ('ASSIS BRASIL DE LIMA', 'abrlima@outlook.com', '003149279-72')
go