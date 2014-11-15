# Base OS
FROM centos:centos7
MAINTAINER shaunol

# Env setup
ENV HOME /root
WORKDIR /root

# Easy way to get apache benchmark
RUN yum install -y httpd-tools

# Output ab docs
# - usage: docker build -t webapi-ab .
#          docker run -t -i -rm webapi-ab ab -n 1000 -c 2 http://[webapi_hostname]:9100/values
CMD ["ab"]