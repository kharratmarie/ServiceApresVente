using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;
using ServiceApresVente.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Ajouter DbContext avec la chaîne de connexion
builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Ajouter les dépôts
builder.Services.AddScoped<IArticlePieceRepository, ArticlePieceRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<IClientArticleRepository, ClientArticleRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IInterventionRepository, InterventionRepository>();
builder.Services.AddScoped<IReclamationRepository, ReclamationRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configuration pour les environnements de production et développement
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Valeur par défaut de HSTS (HTTP Strict Transport Security) pour la production
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Ordre des middlewares : Routing -> Authentification -> Autorisation -> Contrôleur
app.UseRouting();


app.UseAuthorization();

// Configurer les routes des contrôleurs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
