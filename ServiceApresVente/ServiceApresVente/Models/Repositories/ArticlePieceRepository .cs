using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class ArticlePieceRepository : IArticlePieceRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticlePieceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ArticlePiece> GetAll()
        {
            return _context.ArticlePieces.Include(ap => ap.Article).ToList();
        }

        public ArticlePiece GetById(int id)
        {
            return _context.ArticlePieces.Include(ap => ap.Article)
                                         .FirstOrDefault(ap => ap.ArticleId == id);
        }

        public void Add(ArticlePiece articlePiece)
        {
            _context.ArticlePieces.Add(articlePiece);
            _context.SaveChanges();
        }

        public void Update(ArticlePiece articlePiece)
        {
            _context.ArticlePieces.Update(articlePiece);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var articlePiece = _context.ArticlePieces.FirstOrDefault(ap => ap.ArticleId == id);
            if (articlePiece != null)
            {
                _context.ArticlePieces.Remove(articlePiece);
                _context.SaveChanges();
            }
        }

        public IList<ArticlePiece> GetByArticleId(int articleId)
        {
            return _context.ArticlePieces.Where(ap => ap.ArticleId == articleId).ToList();
        }

        public IList<ArticlePiece> GetByPieceId(int pieceId)
        {
            return _context.ArticlePieces.Where(ap => ap.PieceId == pieceId).ToList();
        }
    }
}
