using ForumApi.DAL;
using ForumApi.DAL.Interfaces;
using ForumApi.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = "Data Source=DESKTOP-37E8R7D; Initial Catalog = forumdb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
builder.Services.AddDbContext<ApplicationDbContext>(
    option => option.UseSqlServer(connection));

builder.Services.AddTransient<IPostRepository, PostRepository>();
builder.Services.AddTransient<ISubjectRepository, SubjectRepository>();
builder.Services.AddControllers()/*.AddNewtonsoftJson()*/;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//–аботает и без этого
//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyHeader()); 
//});

//¬озможно работает без этого надо проверить
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
    = new DefaultContractResolver());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//нужно чтобы св€зыватьс€ с сервером
app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
