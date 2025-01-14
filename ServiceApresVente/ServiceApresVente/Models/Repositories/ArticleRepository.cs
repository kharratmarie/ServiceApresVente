using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Récupérer tous les articles
        public IList<Article> GetAll()
        {
            return _context.Articles.Include(a => a.PiecesDisponibles).ToList();
        }

        // Récupérer un article par son identifiant
        public Article GetById(int id)
        {
            return _context.Articles.Include(a => a.PiecesDisponibles)
                                    .FirstOrDefault(a => a.Id == id);
        }

        // Ajouter un nouvel article
        public void Add(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        // Mettre à jour un article existant
        public void Update(Article article)
        {
            _context.Articles.Update(article);
            _context.SaveChanges();
        }

        // Supprimer un article par son identifiant
        public void Delete(int id)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }
        }

        // Récupérer un article par son nom
        public Article GetByNom(string nom)
        {
            return _context.Articles.Include(a => a.PiecesDisponibles)
                                    .FirstOrDefault(a => a.Nom == nom);
        }

        // Récupérer tous les articles par type
        public IList<Article> GetByType(string type)
        {
            return _context.Articles.Where(a => a.Nom.Contains(type)) // Assuming the type is part of the article name
                                    .Include(a => a.PiecesDisponibles).ToList();
        }

        // Récupérer toutes les pièces associées à un article
        public IList<ArticlePiece> GetArticlePiecesByArticleId(int articleId)
        {
            return _context.ArticlePieces.Where(ap => ap.ArticleId == articleId).ToList();
        }
    }
}
