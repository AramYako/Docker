### Docker compose


## Network issues

![image](https://user-images.githubusercontent.com/29054168/216778168-0ab75308-4d39-44f4-89b4-020d90aed374.png)


```
Up: docker-compose up -d
Down: dokcer-compose down
Build and up: docker-compose up --build -d
Status for container in compose: docker-compose ps
```


## file name 

![image](https://user-images.githubusercontent.com/29054168/216780763-ce9e4395-1101-4b73-80db-73d93c2ebc68.png)



## Exampel content
```
version: '3'
services:
  redis-server:
    image: 'redis:latest'
    ports:
      - "6379:6379"
  node-app:
    build: .
    ports:
      - "8081:8081"
    restart: on-failure
```
