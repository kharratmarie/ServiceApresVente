namespace ServiceApresVente.Repositories
{
	public interface IReclamationRepository
	{
		// Récupérer toutes les réclamations
		IList<Reclamation> GetAll();

		// Récupérer une réclamation par son ID
		Reclamation GetById(int id);

		// Ajouter une réclamation
		void Add(Reclamation reclamation);

		// Mettre à jour une réclamation
		void Update(Reclamation reclamation);

		// Supprimer une réclamation par son ID
		void Delete(int id);

		// Récupérer les réclamations d'un client
		IList<Reclamation> GetByClientId(int clientId);

		// Récupérer les réclamations par statut (ex: "Nouvelle", "En cours", "Résolue")
		IList<Reclamation> GetByStatut(string statut);
	}
}
