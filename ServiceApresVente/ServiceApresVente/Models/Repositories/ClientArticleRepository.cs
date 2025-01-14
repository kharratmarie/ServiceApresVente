using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class ClientArticleRepository : IClientArticleRepository 
    {
        private readonly AppDbContext _context;

        public ClientArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public IList<ClientArticle> GetAll()
        {
            return _context.ClientArticles.Include(ca => ca.Client)
                                          .Include(ca => ca.Article)
                                          .ToList();
        }

        public ClientArticle GetById(int id)
        {
            return _context.ClientArticles.Include(ca => ca.Client)
                                          .Include(ca => ca.Article)
                                          .FirstOrDefault(ca => ca.ClientId == id);
        }

        public void Add(ClientArticle clientArticle)
        {
            _context.ClientArticles.Add(clientArticle);
            _context.SaveChanges();
        }

        public void Update(ClientArticle clientArticle)
        {
            _context.ClientArticles.Update(clientArticle);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var clientArticle = _context.ClientArticles.FirstOrDefault(ca => ca.ClientId == id);
            if (clientArticle != null)
            {
                _context.ClientArticles.Remove(clientArticle);
                _context.SaveChanges();
            }
        }

        public IList<ClientArticle> GetByClientId(int clientId)
        {
            return _context.ClientArticles.Where(ca => ca.ClientId == clientId).ToList();
        }

        public IList<ClientArticle> GetByArticleId(int articleId)
        {
            return _context.ClientArticles.Where(ca => ca.ArticleId == articleId).ToList();
        }
    }
}
