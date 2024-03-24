
using HRTechAPI;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));



builder.Services.AddControllers();

var cs = builder.Configuration.GetConnectionString("baglantim");
builder.Services.AddDbContext<UygulamaDbContext>(optionsBuilder => optionsBuilder.UseSqlServer(cs));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();


app.MapControllers();

app.Run();
