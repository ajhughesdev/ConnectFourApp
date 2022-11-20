![Screen Shot 2](https://user-images.githubusercontent.com/69234359/202904993-c9c77162-04fe-40ba-8a07-91cd9c277f55.jpg)

![Mastodon Follow](https://img.shields.io/mastodon/follow/109254332352746633?domain=https%3A%2F%2Fmastodon.ajhughes.dev&style=social) <br>
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/ajhughesdev/ConnectFourApp/Deploy%20Blazor%20WASM%20to%20GitHub%20Pages)   

# Connect Four App

This is a work-in-progress solution to the [Connect Four game](https://www.frontendmentor.io/challenges/connect-four-game-6G8QVH923s) challenge on FrontendMentor.io - a hosted Blazor WebAssembly app.


## Features

> Make your application a **CRUD API**

A **CRUD API** using the Entity Framework Core inluding a [form](https://ajhughesdev.github.io/ConnectFourApp/player) whose input values of initials and score are saved to a localhost database and can be edited and deleted

> Make your application **asynchronous**

**Asychronous** when using the HttpClient service to consume a web API

> Create a dictionary or **list**, populate it with several values, retrieve at least one value, and use it in your program

A **List** populated with a retrievable value representing every playable space on the board and used for various dynamic UI elements throughout game play


## API Reference

#### Get all reservations

```csharp
[HttpGet]
public Task<IActionResult> Get()
in class PlayerController
```

#### Get reservation by "Id"

```csharp
[HttpGet("{id}")]
public Task<IActionResult> Get(int id)
in class PlayerController
```

#### Create reservation

```csharp
[HttpPost]
public Task<IActionResult> Put(Player player)
in class PlayerController
```

#### Edit reservation

```csharp
[HttpPut]
public Task<IActionResult> Put(Player player)
in class PlayerController
```

#### Delete reservation by "Id"

```csharp
[HttpDelete("{id}")]
public Task<IActionResult> Delete(int id)
in class PlayerController
```


| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Id`      | `int`    | **Key** Id of player              |  
| `Initials`| `string` | **Required** Initials of player   |
| `Score`   | `int`    | **Required** Score of player      |


## Authors

- [@ajhughesdev](https://www.github.com/ajhughesdev)


## Acknowledgements

 - [Intro to Web Development with .NET](https://github.com/dotnet/intro-to-dotnet-web-dev)
 - [readme.so](https://github.com/octokatherine/readme.so)
 - [Blazor WebAssembly : Call Web APIs to perform CRUD](https://www.yogihosting.com/blazor-webassembly-web-api-crud/)

