var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lab 4 - Week5Api");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();

app.MapGet("/hello", () => "Hello from your Azure API running .NET 9")
    .WithName("GetHello")
    .WithOpenApi();

app.Run();