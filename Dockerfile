# Base OS
FROM shaunol/centos-mono:latest
MAINTAINER shaunol

# Env setup
EXPOSE 9100
ENV HOME /root
WORKDIR /root

ADD webapi.tar /root/

# Todo cloud based config
ENTRYPOINT ["mono", "/root/webapi/OwinMonoSelfHostTest.exe"]