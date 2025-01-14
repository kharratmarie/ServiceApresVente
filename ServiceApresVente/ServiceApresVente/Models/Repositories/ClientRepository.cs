using Microsoft.EntityFrameworkCore;
using ServiceApresVente.Context;
using ServiceApresVente.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceApresVente.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        // Récupérer tous les clients
        public IList<Client> GetAll()
        {
            return _context.Clients.Include(c => c.Reclamations).ToList();
        }

        // Récupérer un client par son identifiant
        public Client GetById(int id)
        {
            return _context.Clients.Include(c => c.Reclamations)
                                   .FirstOrDefault(c => c.Id == id);
        }

        // Ajouter un nouveau client
        public void Add(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        // Mettre à jour un client existant
        public void Update(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        // Supprimer un client par son identifiant
        public void Delete(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        // Rechercher un client par son email
        public Client GetByEmail(string email)
        {
            return _context.Clients.Include(c => c.Reclamations)
                                   .FirstOrDefault(c => c.Email == email);
        }

        // Récupérer toutes les réclamations d'un client
        public IList<Reclamation> GetReclamationsByClientId(int clientId)
        {
            return _context.Reclamations.Where(r => r.ClientId == clientId).ToList();
        }
    }
}
