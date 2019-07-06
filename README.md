Aplicação desenvolvida pelos estudantes [Leonardo Sena](https://www.github.com/leosena21), [Bruna Andrade](https://www.github.com/brunandrade), [Tarcio Carvalho](https://www.github.com/Tarcioc2) e [Gabriel Luiz](https://github.com/gabrielluiz97) do curso de Engenharia de Computação para obtenção de nota da 3ª Unidade de Sistemas Distribuidos.

# Informações:

O objetivo do trabalho é colocar em prática todos os conhecimentos adquiridos na disciplina. Para isso, faz-se necessária a criação de um ambiente distribuído para sistemas Web que consumam Banco de Dados.
Abaixo seguem as informações necessárias para a realização do trabalho final:

Nome: Ambiente Web Distribuído

Conteiner WEB
----------------------
Criar um cluster em docker contendo 5 conteineres WEB que deverão operar em conjunto. Para o cliente, o sistema deve parecer um único site. Esse site deverá conter:

* Uma operação CRUD (CREATE, RECOVER, UPDATE, DELETE) simples que permita testar a idéia.
* Um indicador de qual conteiner a aplicação está rodando.

Com relação ao cluster, caso um conteiner pare de funcionar, outro deve ser levantado para suprir a necessidade de termos 5 conteineres sempre rodando.


Conteiner DB
-------------------
Criar dois conteineres de Banco de dados onde o principal receberá as requisições de DDL e DML e deverá enviá-las para um servidor espelho que servirá como redundância.


# Como rodar o CRUDReplication:

docker swarm init
docker build -t paca .
docker stack deploy -c docker-compose.yml livrariadocajah

docker service ls

CREATE TABLE `example`.`Livros` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Autor` LONGTEXT NULL,
  `Lancamento` DATETIME NULL,
  `Nome` LONGTEXT NULL,
  `Preco` DECIMAL(65,30) NULL,
  PRIMARY KEY (`Id`));
  
  Aplicação web rodando em porta 8080
  Mysql_Master em 7701
  Mysel_Slave em 7702
  Demais configurações acessar o docker-compose.yml

Banco Mysql: https://hub.docker.com/r/actency/docker-mysql-replication/
