using BLL.functions;
using BLL.interfaces;
using DAL.functions;
using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Connection to database
builder.Services.AddDbContext<MagicalDBContext>
    //Scaffold-DbContext "Server= DESKTOP-9RJSA7C\SQLEXPRESS;Database=MagicalDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir models
    (y => y.UseSqlServer("Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=MagicalDB1;Trusted_Connection=True;TrustServerCertificate=True;"));
//הזרקת תלויות
builder.Services.AddScoped<ICityDAL, FCityDAL>();
builder.Services.AddScoped<ICityBLL, CityBLL>();

builder.Services.AddScoped<IUserDAL, FUserDAL>();
builder.Services.AddScoped<IUserBLL, UserBLL>();

builder.Services.AddScoped<ICategoryDAL, FCategoryDAL>();
builder.Services.AddScoped<ICategoryBLL, CategoryBLL>();

builder.Services.AddScoped<IOrdersDAL, FOrdersDAL>();
builder.Services.AddScoped<IOrdersBLL, OrdersBLL>();

builder.Services.AddScoped<ICategoryProductDAL, FCategoryProductDAL>();
builder.Services.AddScoped<ICategoryProductBLL, CategoryProductBLL>();

builder.Services.AddScoped<IColorDAL, FColorDAL>();
builder.Services.AddScoped<IColorBLL, ColorBLL>();

builder.Services.AddScoped<IPictureDAL, FPictureDAL>();
builder.Services.AddScoped<IPictureBLL, PictureBLL>();

builder.Services.AddScoped<IProductDAL, FProductDAL>();
builder.Services.AddScoped<IProductBLL, ProductBLL>();

builder.Services.AddScoped<IProductOrderDAL, FProductOrderDAL>();
builder.Services.AddScoped<IProductOrderBLL, ProductOrderBLL>();

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
