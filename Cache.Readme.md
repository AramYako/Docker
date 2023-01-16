Cache

When no changes, docker will build image from cache 

![image](https://user-images.githubusercontent.com/29054168/212781003-e5426c72-2364-4300-adf6-258ee89c77d2.png)


### Changes to source code

Everytinhg after the change wont be cached

![image](https://user-images.githubusercontent.com/29054168/212781102-1693ec1b-ef70-4f2c-9c37-d9e7640d115b.png)

```
When source code has changes, COPY . . will not fetch from cache and everything after will not be cached
```


### Smart docker file to use cache

![image](https://user-images.githubusercontent.com/29054168/212781153-c52dcc1b-182d-48a1-ab52-73f827cfa2f7.png)

```
Create WorkerDir, copy esential files, and install npm before "ADD . ." So when source code changes happens, we will not install npm everytime we build image
```
