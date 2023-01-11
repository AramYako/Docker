# Docker commands



## Containers



```
Stop all containers:	 docker stop $(docker ps -aq)
Start all containers:	 docker start $(docker ps -aq)
Remove all containers:	 docker rm $(docker ps -aq)
Remove all containers even running:	 docker rm -f $(docker ps -aq)
```

## Format
```
docker ps -a --format "Id:\t{{.ID}}\nName: {{.Names}}\nport {{.Ports}}\nImage\t {{.Image}}\n"

Format with envrionmentVariable

Create variable: $formatNice ="Id:\t{{.ID}}\nName: {{.Names}}\nport {{.Ports}}\nImage\t {{.Image}}\n"
Output format:  docker ps -a --format=$formatNice
```
## Shell on container
```
docker exec -it <id> /bin/bash
```

## Volume read only source

![image](https://user-images.githubusercontent.com/29054168/211686326-47fa4537-ad29-4ca1-95ec-b2327701e622.png)
```
## Volume read only source
docker run --name website -v C:\Repo\DockerTest:/usr/share/nginx/html:ro -d -p 8080:80 nginx:latest
```

## Volume write source

![image](https://user-images.githubusercontent.com/29054168/211686797-d3083bde-a306-4c49-ad3c-1350c1132485.png)

### If file is created in the destination, it is also created in the source
```
## Volume with write able source 
docker run --name website -v ${PWD}:/usr/share/nginx/html -d -p 8080:80 nginx:latest

## Volume current work directory 
docker run --name website -v ${PWD}:/usr/share/nginx/html -d -p 8080:80 nginx:latest
```

### Share volume containers
```
## Volume will point at another container called  "charming_sanderson" and use its volume 
docker run --volumes-from charming_sanderson -d -p 8081:80 nginx

```

