# 🛒 Projeto de Vendas - C# com MySQL

Este é um sistema de vendas desenvolvido em C# com Windows Forms, utilizando MySQL como banco de dados. Ele permite o gerenciamento completo de clientes, fornecedores, funcionários, produtos e vendas.

## ⚙️ Funcionalidades
Cadastro de clientes, fornecedores e funcionários

Controle de produtos e estoque;

Registro e listagem de vendas;

Relatório de itens vendidos;

Autenticação com diferentes níveis de acesso;

## 🧱 Tecnologias Utilizadas
C# (.NET Framework / Windows Forms)

MySQL (local)

MySQL Connector para .NET

## 🖥️ Como Executar
1. Clone o projeto
   
```bash
git clone https://github.com/seu-usuario/projeto-vendas.git
```


2. Configure o banco de dados
   
3. Abra o MySQL Workbench, DBeaver ou outro cliente de banco de dados MySQL e execute o seguinte script para criar o banco e as tabelas necessárias:

```sql
CREATE DATABASE BDVENDAS;

CREATE USER 'teste'@'%' IDENTIFIED BY '123';
GRANT ALL ON *.* TO 'teste'@'%' WITH GRANT OPTION;
FLUSH PRIVILEGES;

USE BDVENDAS;

/***** TABELA CLIENTES *****/
CREATE TABLE tb_clientes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100),
  rg VARCHAR(30),
  cpf VARCHAR(20),
  email VARCHAR(200),
  telefone VARCHAR(30),
  celular VARCHAR(30),
  cep VARCHAR(100),
  endereco VARCHAR(255),
  numero INT,
  complemento VARCHAR(200),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  estado VARCHAR(2)
);
/*****************/

/***** TABELA FORNECEDORES *****/
CREATE TABLE tb_fornecedores (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100),
  cnpj VARCHAR(100),
  email VARCHAR(200),
  telefone VARCHAR(30),
  celular VARCHAR(30),
  cep VARCHAR(100),
  endereco VARCHAR(255),
  numero INT,
  complemento VARCHAR(200),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  estado VARCHAR(2)
);
/*****************/

/***** TABELA FUNCIONÁRIOS *****/
CREATE TABLE tb_funcionarios (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100),
  rg VARCHAR(30),
  cpf VARCHAR(20),
  email VARCHAR(200),
  senha VARCHAR(10),
  cargo VARCHAR(100),
  nivel_acesso VARCHAR(50),
  telefone VARCHAR(30),
  celular VARCHAR(30),
  cep VARCHAR(100),
  endereco VARCHAR(255),
  numero INT,
  complemento VARCHAR(200),
  bairro VARCHAR(100),
  cidade VARCHAR(100),
  estado VARCHAR(2)
);
/*****************/

/***** TABELA PRODUTOS *****/
CREATE TABLE tb_produtos (
  id INT AUTO_INCREMENT PRIMARY KEY,
  descricao VARCHAR(100),
  preco DECIMAL(10,2),
  qtd_estoque INT,
  for_id INT,
  FOREIGN KEY (for_id) REFERENCES tb_fornecedores(id)
);
/*****************/

/***** TABELA VENDAS *****/
CREATE TABLE tb_vendas (
  id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT,
  data_venda DATETIME,
  total_venda DECIMAL(10,2),
  observacoes TEXT,
  FOREIGN KEY (cliente_id) REFERENCES tb_clientes(id)
);
/*****************/

/***** TABELA ITENS_VENDAS *****/
CREATE TABLE tb_itensvendas (
  id INT AUTO_INCREMENT PRIMARY KEY,
  venda_id INT,
  produto_id INT,
  qtd INT,
  subtotal DECIMAL(10,2),
  FOREIGN KEY (venda_id) REFERENCES tb_vendas(id),
  FOREIGN KEY (produto_id) REFERENCES tb_produtos(id)
);
/*****************/

/***** CONSULTA EXEMPLO *****/
SELECT * FROM tb_clientes WHERE nome LIKE 'a%';
```
