namespace ServiceApresVente.Repositories
{
    public interface IClientRepository
    {
        // R�cup�rer tous les clients
        IList<Client> GetAll();

        // R�cup�rer un client par son identifiant
        Client GetById(int id);

        // Ajouter un nouveau client
        void Add(Client client);

        // Mettre � jour un client existant
        void Update(Client client);

        // Supprimer un client par son identifiant
        void Delete(int id);

        // Rechercher un client par son email
        Client GetByEmail(string email);

        // R�cup�rer toutes les r�clamations d'un client
        IList<Reclamation> GetReclamationsByClientId(int clientId);
    }
}
