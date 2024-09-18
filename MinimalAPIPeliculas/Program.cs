var builder = WebApplication.CreateBuilder(args);

//Area de los servicios



//Fin de area de los servicios

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
