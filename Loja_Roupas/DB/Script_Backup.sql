CREATE DATABASE LOJA_ROUPAS;

USE LOJA_ROUPAS;

CREATE TABLE fornecedorES (
id_fornecedor int PRIMARY KEY AUTO_INCREMENT,
Denominacao_Social varchar(60),
endereco varchar(60),
numero varchar(8),
Cnpj varchar(18),
cidade varchar(30),
uf char(2),
telefone varchar(15),celular1 varchar(15),
celular2 varchar(15),
observacao varchar(100),
Email varchar(100),
data_cadastro date
);                

CREATE TABLE Contas (
id_CONTA int PRIMARY KEY AUTO_INCREMENT,
descricao varchar(50),
valor float(7,2),
Juros float(4,2),
data date,
data_vencimento date,
status enum('Pago', 'Pendente'),
credor Varchar(30)
);

CREATE TABLE Produtos (
id_produto int PRIMARY KEY AUTO_INCREMENT,
descricao varchar(100),
tamanho varchar(10),
categoria enum('Adulto', 'Infantil'),
Genero enum('Masculino', 'Feminino', 'Unissex'),
valor_compra float(6,2),
valor_venda float(6,2),
Quantidade int(4),
taxa float(4,2),
tecido varchar(20),
data_cadastro date,
fornecedor_id int
);

CREATE TABLE lista_produtos (
id_lista_produtos int PRIMARY KEY AUTO_INCREMENT,
produto_id int,
venda_id int,
quantidade int(3)
);

CREATE TABLE vendas (
id_venda int PRIMARY KEY AUTO_INCREMENT,
Total float(7,2),
cliente_id int,
lista_produtos_id int,
Desconto float(4,2),
Forma_PAgamento varchar(7),
Data_Venda date
);

CREATE TABLE usuarios (
id_usuario int PRIMARY KEY AUTO_INCREMENT,
login varchar(20),
senha varchar(20),
nome_usuario varchar(60)
);

CREATE TABLE Promissorias (
id_promissoria int PRIMARY KEY AUTO_INCREMENT,
cliente_id int,
valor float(7,2),
data_emissao date,
data_vencimento date,
juros_vencimento float(4,2),
Status enum("Pago","Pendente")
venda_id int,
);



	

CREATE TABLE Clientes (
id_cliente int PRIMARY KEY AUTO_INCREMENT,
nome varchar(60),
data_Nascimento VARCHAR(12),
CPF varchar(14),
Cidade Varchar(30),
Celular1 VARCHAR(15),
endereco Varchar(60),
Num_Casa varchar(8),
telefone varchar(15),
celular2 varchar(15),
Observacao VARCHAR(100),
Data_Cadastro date
);




ALTER TABLE PROMISSORIAS ADD CONSTRAINT FK_PROMISSORIAS_CLIENTES
FOREIGN KEY (CLIENTE_ID) REFERENCES CLIENTES(ID_CLIENTE);

ALTER TABLE PROMISSORIAS ADD CONSTRAINT FK_PROMISSORIAS_VENDAS
FOREIGN KEY (VENDA_ID) REFERENCES VENDAS(ID_VENDA);

ALTER TABLE VENDAS ADD CONSTRAINT FK_VENDAS_CLIENTES
FOREIGN KEY (CLIENTE_ID) REFERENCES CLIENTES(ID_CLIENTE);

ALTER TABLE VENDAS ADD CONSTRAINT FK_VENDAS_LISTAPRODUTOS
FOREIGN KEY (LISTA_PRODUTOS_ID) REFERENCES LISTA_PRODUTOS(ID_LISTA_PRODUTOS);

ALTER TABLE LISTA_PRODUTOS ADD CONSTRAINT FK_LISTA_PRODUTOS_PRODUTOS
FOREIGN KEY (PRODUTO_ID) REFERENCES PRODUTOS(ID_PRODUTO);

ALTER TABLE LISTA_PRODUTOS ADD CONSTRAINT FK_LISTA_PRODUTOS_VENDAS
FOREIGN KEY (VENDA_ID) REFERENCES VENDAS(ID_VENDA);

ALTER TABLE PRODUTOS ADD CONSTRAINT FK_PRODUTOS_FORNECEDORES
FOREIGN KEY (FORNECEDOR_ID) REFERENCES FORNECEDORES(ID_FORNECEDOR);