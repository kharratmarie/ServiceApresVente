using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;
namespace ServiceApresVente.Repositories
{
    public class ArticlePieceRepository : IArticlePieceRepository
    {
        private readonly AppDbContext _context;

        public ArticlePieceRepository(AppDbContext context)
        {
            _context = context;
        }

        public IList<ArticlePiece> GetAll()
        {
            return _context.Pieces.Include(ap => ap.Article).ToList();
        }

        public ArticlePiece GetById(int id)
        {
            return _context.Pieces.Include(ap => ap.Article)
                                         .FirstOrDefault(ap => ap.ArticleId == id);
        }

        public void Add(ArticlePiece articlePiece)
        {
            _context.Pieces.Add(articlePiece);
            _context.SaveChanges();
        }

        public void Update(ArticlePiece articlePiece)
        {
            _context.Pieces.Update(articlePiece);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var articlePiece = _context.Pieces.FirstOrDefault(ap => ap.ArticleId == id);
            if (articlePiece != null)
            {
                _context.Pieces.Remove(articlePiece);
                _context.SaveChanges();
            }
        }

        public IList<ArticlePiece> GetByArticleId(int articleId)
        {
            return _context.Pieces.Where(ap => ap.ArticleId == articleId).ToList();
        }

        public IList<ArticlePiece> GetByPieceId(int pieceId)
        {
            return _context.Pieces.Where(ap => ap.Id == pieceId).ToList();
        }
    }
}
