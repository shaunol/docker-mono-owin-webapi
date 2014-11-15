ab-webapi
=======================

TODO..

Build docker file:
docker build -t webapi-ab .

Output ab help:
docker run -t -i -rm webapi-ab

Run 1000 http requests with a concurrency level of 2:
docker run -t -i -rm webapi-ab ab -n 1000 -c 2 http://[docker_hostname]:9100/values