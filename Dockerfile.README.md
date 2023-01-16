
# Docker file commands



## Simple file

![image](https://user-images.githubusercontent.com/29054168/212553138-3a0d2606-8fab-4b40-a114-986d9aae2212.png)


```
FROM: What Base image to use: nginx:latest
Add: . (add all content in current directory) and  (/usr/share/nginx/html): Destination
```

### BUILD docker file to image
```
docker build  -t name:version . (source)
```


