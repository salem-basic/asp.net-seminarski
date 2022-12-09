using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services;
using SeminarskiTest.Controllers;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;

var builder = WebApplication.CreateBuilder(args);
var myAllowDifferentOrigins = "_myAllowDifferentOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    
});


builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();


builder.Services.AddAutoMapper(typeof(IProizvodService));
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddTransient<IDrzavaService, DrzavaService>();
builder.Services.AddTransient<IKarticaService, KarticaService>();
builder.Services.AddTransient<IKategorijaService, KategorijaService>();
builder.Services.AddTransient<INaruzdbaService, NarudzbaService>();
builder.Services.AddTransient<IProizvodService, ProizvodService>();
builder.Services.AddTransient<ISpolService, SpolService>();
builder.Services.AddTransient<IValutaService, ValutaService>();
builder.Services.AddTransient<IBrendService, BrendService>();
builder.Services.AddTransient<IDobavljacService, DobavljacService>();
builder.Services.AddTransient<IProdavnicaService, ProdavnicaService>();
builder.Services.AddTransient<IDostavljacService, DostavljacService>();
builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddSingleton<TimeManager>();

builder.Services.ConfigureSwaggerDoc();
builder.Services.AddSignalR();
builder.Services.AddRazorPages();

builder.Services.AddIdentityCore<IdentityUser>(
    options => {
        options.SignIn.RequireConfirmedAccount = true;
        options.User.RequireUniqueEmail = false;
    })
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowDifferentOrigins,
        builder => {
            builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.UseCors(myAllowDifferentOrigins);

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//    endpoints.MapRazorPages();
//    endpoints.MapHub<ChartHub>("/Chart");
//});
app.MapControllers();
app.MapRazorPages();
app.MapHub<ChartHub>("/Chart");

app.Run();


//public class ApplicationUser : IdentityUser<int>
//{
//    public DateTime CreatedAt { get; set; }
//    public DateTime? ModifiedAt { get; set; }
//    public bool IsDeleted { get; set; }
//    public bool Active { get; set; }
//}

//public class ApplicationRole : IdentityRole<int>
//{
//    public int? RoleLevel { get; set; }
//    public DateTime CreatedAt { get; set; } = DateTime.Now;
//    public DateTime? ModifiedAt { get; set; }
//    public bool IsDeleted { get; set; }

//    public ICollection<ApplicationUserRole> Roles { get; set; }


//}

//public class ApplicationUserRole : IdentityUserRole<int>
//{
//    public int Id { get; set; }
    
//    public ApplicationUser User { get; set; }
//    public ApplicationRole Role { get; set; }
//    public DateTime CreatedAt { get; set; }
//    public DateTime? ModifiedAt { get; set; }
//    public bool IsDeleted { get; set; }
//}