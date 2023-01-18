### How to access a container shell
```
docker exec -it dockerId /bin/sh
```

### if you forgot how to go to bash (/bin/sh) what can you do? 

```
docker inspect <dockerId> 
- Look for cmd
```

![image](https://user-images.githubusercontent.com/29054168/213314757-4f7dffa1-7ea8-4864-aa26-d70a9316b37f.png)
