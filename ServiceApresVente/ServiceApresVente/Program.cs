using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContextPool<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Configure the HTTP request pipeline.


builder.Services.AddScoped<IArticlePieceRepository, ArticlePieceRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IClientArticleRepository, ClientArticleRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IInterventionRepository, InterventionRepository>();
builder.Services.AddScoped<IReclamationRepository, ReclamationRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();






if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
