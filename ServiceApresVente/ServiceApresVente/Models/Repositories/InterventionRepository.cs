using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class InterventionRepository : IInterventionRepository
    {
        private readonly ApplicationDbContext _context;

        public InterventionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Intervention> GetAll()
        {
            return _context.Interventions.Include(i => i.Reclamation).ToList();
        }

        public Intervention GetById(int id)
        {
            return _context.Interventions.Include(i => i.Reclamation)
                                         .FirstOrDefault(i => i.Id == id);
        }

        public void Add(Intervention intervention)
        {
            _context.Interventions.Add(intervention);
            _context.SaveChanges();
        }

        public void Update(Intervention intervention)
        {
            _context.Interventions.Update(intervention);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var intervention = _context.Interventions.FirstOrDefault(i => i.Id == id);
            if (intervention != null)
            {
                _context.Interventions.Remove(intervention);
                _context.SaveChanges();
            }
        }

        public IList<Intervention> GetByReclamationId(int reclamationId)
        {
            return _context.Interventions.Where(i => i.ReclamationId == reclamationId).ToList();
        }

        public IList<Intervention> GetByGarantie(bool sousGarantie)
        {
            return _context.Interventions.Where(i => i.SousGarantie == sousGarantie).ToList();
        }
    }
}
