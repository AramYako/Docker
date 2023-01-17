### Docker Tag

## Strategy

![image](https://user-images.githubusercontent.com/29054168/213036388-7749041b-8a14-4283-a9e5-c8ca29b7d068.png)


```
1. Create an image with tag latest 
 - docker build -t api-user:latest .     
 
2. Create now a version based on latest
- docker tag api-user:latest api-user:v2

Docker latest will always point to the latest version
```
