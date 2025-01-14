using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class ReclamationRepository : IReclamationRepository
    {
        private readonly AppDbContext _context;

        public ReclamationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IList<Reclamation> GetAll()
        {
            return _context.Reclamations.Include(r => r.Client).ToList();
        }

        public Reclamation GetById(int id)
        {
            return _context.Reclamations.Include(r => r.Client)
                                        .FirstOrDefault(r => r.Id == id);
        }

        public void Add(Reclamation reclamation)
        {
            _context.Reclamations.Add(reclamation);
            _context.SaveChanges();
        }

        public void Update(Reclamation reclamation)
        {
            _context.Reclamations.Update(reclamation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var reclamation = _context.Reclamations.FirstOrDefault(r => r.Id == id);
            if (reclamation != null)
            {
                _context.Reclamations.Remove(reclamation);
                _context.SaveChanges();
            }
        }

        public IList<Reclamation> GetByClientId(int clientId)
        {
            return _context.Reclamations.Where(r => r.ClientId == clientId).ToList();
        }

        public IList<Reclamation> GetByStatut(string statut)
        {
            return _context.Reclamations.Where(r => r.Statut == statut).ToList();
        }
    }
}
