var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola mundo!");

app.MapPost("/login", (MinimalApi.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admin@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso");
    }
    return Results.Unauthorized();
});


app.Run();

