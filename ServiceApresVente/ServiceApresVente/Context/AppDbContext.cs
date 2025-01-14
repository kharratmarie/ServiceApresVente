

namespace ServiceApresVente.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Reclamation> Reclamations { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticlePiece> Pieces { get; set; }
        public DbSet<ClientArticle> ClientArticles { get; set; } // Classe d'association



    }

}
