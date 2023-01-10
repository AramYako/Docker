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
docker exec -it 7f3fd49ba9c3 /bin/bash
```

