using Microsoft.EntityFrameworkCore;
using Quiz1.Data;
using Quiz1.Repos;
using Quiz1.Repos.Abstraction;
using Quiz1.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped(typeof(IStudent), typeof(StudentRepo));
builder.Services.AddScoped(typeof(ITeachear), typeof(TeachearRepo));
builder.Services.AddScoped(typeof(ISubject), typeof(SubjectRepo));
builder.Services.AddScoped(typeof(IClassRoom), typeof(ClassRoomRepo));
builder.Services.AddScoped(typeof(IEnrollment), typeof(EnrollmentRepo));
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkRepo>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
