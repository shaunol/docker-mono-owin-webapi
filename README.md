docker-mono-owin-webapi
=======================

TODO..

Run in current terminal session and remove container on exit:

docker run -i -rm -p 9100:9100 shaunol/mono-owin-webapi

Run as a daemon (requires manual container cleanup after use):

docker run -d -p 9100:9100 shaunol/mono-owin-webapi

Browse to http://[docker_hostname]:9100/values to confirm operation

Executable is from webapi.tar

See ./webapi-src for the .net source code

Benchmark:
docker run -t -i -rm shaunol/docker-ab ab -n 1000 -c 2 http://[docker_hostname]:9100/values