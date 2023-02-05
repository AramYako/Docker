
# Docker file commands

![image](https://user-images.githubusercontent.com/29054168/212777285-91af803f-b616-412d-811f-edf97741e928.png)


### BUILD docker file to image
```
docker build  -t namespace/repository:tagName . (source)
docker build -f dockerfiles/Dockerfile.prod  -t myapp_prod .

```


## Simple file

![image](https://user-images.githubusercontent.com/29054168/212776791-55edf969-8979-43de-9372-08ea0feffa42.png)


```
FROM: What Base image to use: nginx:latest
Copy: . (Copy all content in current directory) and  (/usr/share/nginx/html): Destination
```

### WORKDIR
![image](https://user-images.githubusercontent.com/29054168/212777040-fe5b71d6-d0d9-4974-9651-a78bf52b7adf.png)

```
Created a work directory when creating container. Here the sources files are copied
- The WORKDIR instruction sets the working directory for any RUN, CMD, ENTRYPOINT, COPY and ADD instructions that follow it in the Dockerfile.
```


