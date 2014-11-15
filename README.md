docker-mono-owin-webapi
=======================

Run in current terminal session and remove container on exit:

```
docker run --rm -t -i -p 9100:9100 shaunol/mono-owin-webapi
```

Run as a daemon (requires manual container cleanup after use):

```
docker run -d -p 9100:9100 shaunol/mono-owin-webapi
```

Browse to http://[docker_hostname]:9100/values to confirm operation

Executable is from webapi.tar

See ./webapi-src for the .net source code

Benchmark:

```
docker run --rm -t -i shaunol/docker-ab ab -n 1000 -c 2 http://[docker_hostname]:9100/values
```

cpuThreads * 1.5 seems like a good formula to start with regarding max. concurrency levels

1100 requests per second were observed from aws t1.micro -> t1.micro instance (c=2, no network placement group, 1 vCPU, unknown ECUs)

4600 requests per second from c3.2xlarge -> c3.2xlarge instance (c=12, in same network placement group, 8 vCPU, 28 ECUs, ixgbevf 2.11.3-k)

5600 requests per second from c3.8xlarge -> c3.8xlarge instance (c=48, in same network placement group, 32 vCPU, 108 ECUs, ixgbevf 2.11.3-k)

Going to have to play with some different benchmark methods, it's most likely the ab client needs to be distributed and maybe the .net threadpool settings need to be tweaked on the server side.