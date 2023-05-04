var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();//mudanca a partir da 1.0.0
    //mudanca 2
    //mudanca 3
    //mudanca 4
    //mudanca 5
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
