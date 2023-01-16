
# Docker file commands



## Simple file

![image](https://user-images.githubusercontent.com/29054168/212773352-261eb7bc-91de-4bd5-8bb0-84ef0a0ed8b1.png)


```
FROM: What Base image to use: nginx:latest
Copy: . (Copy all content in current directory) and  (/usr/share/nginx/html): Destination
```

### BUILD docker file to image
```
docker build  -t name:version . (source)
```


