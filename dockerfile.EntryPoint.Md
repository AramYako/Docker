#docker run image 100 # will make sure to override cmd 5 and execute sleep 100
# docker run image # will not ovrride cmd and will execute sleep 5 

FROM ubuntu:latest

WORKDIR /app

COPY . . 

ENTRYPOINT [ "sleep" ]

CMD [ "5" ]
