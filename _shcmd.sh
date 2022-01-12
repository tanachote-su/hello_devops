#!/bin/sh

echo "Clean Environment ..."
docker rm -f hello_devops
docker rmi -f hello_devops
echo
echo "Build && Run ..."
docker build -f ./hello_devops/Dockerfile -t hello_devops .
docker run -d --name hello_devops hello_devops

#winpty docker exec -it hello_devops bash
#docker inspect hello_devops
echo
echo "Open logs ..."
docker logs hello_devops -f