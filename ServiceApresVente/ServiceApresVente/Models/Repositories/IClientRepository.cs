namespace ServiceApresVente.Repositories
{
    public interface IClientRepository
    {
        // Récupérer tous les clients
        IList<Client> GetAll();

        // Récupérer un client par son identifiant
        Client GetById(int id);

        // Ajouter un nouveau client
        void Add(Client client);

        // Mettre à jour un client existant
        void Update(Client client);

        // Supprimer un client par son identifiant
        void Delete(int id);

        // Rechercher un client par son email
        Client GetByEmail(string email);

        // Récupérer toutes les réclamations d'un client
        IList<Reclamation> GetReclamationsByClientId(int clientId);
    }
}
