# RGRProject
#### Система бронювання робочого місця (кафе, коворкінгу) онлайн

### Необхідне ПО і бібліотеки: 
- .Net Core 2.1 Tools
- .Net Core SDK
- Visual Studio 2017
- NodeJS v9.3.0
- NPM v6.3.0
- Angular CLI v7.0.2

### Запуск проекту
- Відкрити RGRProject.sln в VS2017 і виконати запуск проекту - вс задачі виконаються автоматично

### Збірка проекту за допомогою  CLI
```
dotnet build --configuration Release
```

### Публікація проекту
```
dotnet publish --output /build_output
```

### Документація API
localhost://<port_name>/swagger
або
http://52.233.138.86:8097/swagger

### Запуск бота за допомогою Docker
```
$ docker build -t RGRProject .
```
```
$ docker run -d -p 8080:80 --name RGRProject aspnetapp
```

### Над проектом працювали :
Команда: "Pasosh"
- Ярошенко Олександр
- Сташенко Марія
- Суліменко Микита
