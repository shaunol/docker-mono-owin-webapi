docker-mono-owin-webapi
=======================

TODO..

docker run -d -p -rm 9100:9100 shaunol/mono-owin-webapi

Attach to see example output or browse to http://[docker_hostname]:9100/values

Executes code from webapi.tar

See ./webapi-src for the .net source code

Benchmark:
docker run -t -i -rm shaunol/docker-ab ab -n 1000 -c 2 http://[docker_hostname]:9100/values