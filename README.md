"# CRUDReplication" 


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