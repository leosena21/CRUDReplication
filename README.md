"# CRUDReplication" 

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

https://hub.docker.com/r/actency/docker-mysql-replication/

docker run -d \
 --name mysql_master \
 -v /data/mastermysql:/var/lib/mysql \
 -e MYSQL_ROOT_PASSWORD=mysqlroot \
 -e MYSQL_USER=example_user \
 -e MYSQL_PASSWORD=mysqlpwd \
 -e MYSQL_DATABASE=example \
 -e REPLICATION_USER=replication_user \
 -e REPLICATION_PASSWORD=myreplpassword \
 actency/docker-mysql-replication:5.7

docker run -d \
 --name mysql_slave \
 -v /data/slavemysql:/var/lib/mysql \
 -e MYSQL_ROOT_PASSWORD=mysqlroot \
 -e MYSQL_USER=example_user \
 -e MYSQL_PASSWORD=mysqlpwd \
 -e MYSQL_DATABASE=example \
 -e REPLICATION_USER=replication_user \
 -e REPLICATION_PASSWORD=myreplpassword \
 --link mysql_master:master \
 actency/docker-mysql-replication:5.7

Verificar inserir portas e verificar a replicação;
