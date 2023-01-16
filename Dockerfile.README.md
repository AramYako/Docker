
# Docker file commands



## Simple file

![image](https://user-images.githubusercontent.com/29054168/212776791-55edf969-8979-43de-9372-08ea0feffa42.png)


```
FROM: What Base image to use: nginx:latest
Copy: . (Copy all content in current directory) and  (/usr/share/nginx/html): Destination
```

### BUILD docker file to image
```
docker build  -t name:version . (source)
```


