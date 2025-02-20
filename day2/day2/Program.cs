using day2.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CustomCorsPolicy");

app.UseAuthorization();
app.UseFirstMiddleware();
app.UseSecondMiddleware();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    Console.WriteLine($".Use Middleware");
    await next();
});

app.MapControllers();

app.Run();
