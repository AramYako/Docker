* docker run image 100: Will make sure to override cmd 5 and execute sleep 100
* docker run image: will not ovrride cmd and will execute sleep 5 
* docker run --entrypoint sleep2.0 image 10: Will override entrypoint to sleep2.0 and pass paramter 10 so "sleep2.0 10"


FROM ubuntu:latest

WORKDIR /app

COPY . . 

ENTRYPOINT [ "sleep" ]

CMD [ "5" ]
