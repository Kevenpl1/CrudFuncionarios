/*O comando database sé utilizado para criar banco de dados*/
create database dbFuncionarios
default character set utf8mb4
default collate utf8mb4_general_ci;

/* o comando use serve para utilizar o banco de dados desejado*/
use dbFuncionarios;


create table if not exists funcionarios (
	id int not null auto_increment primary key,
    nome varchar(200) not null,
    email varchar(200) not null,
    cpf varchar(11) not null,  /* cpf com mascara 111.111.111-11 (14)*/
    endereco varchar(200) not null
)default char set utf8mb4;