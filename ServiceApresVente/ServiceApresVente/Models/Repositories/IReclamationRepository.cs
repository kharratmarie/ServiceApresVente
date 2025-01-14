namespace ServiceApresVente.Repositories
{
	public interface IReclamationRepository
	{
		// R�cup�rer toutes les r�clamations
		IList<Reclamation> GetAll();

		// R�cup�rer une r�clamation par son ID
		Reclamation GetById(int id);

		// Ajouter une r�clamation
		void Add(Reclamation reclamation);

		// Mettre � jour une r�clamation
		void Update(Reclamation reclamation);

		// Supprimer une r�clamation par son ID
		void Delete(int id);

		// R�cup�rer les r�clamations d'un client
		IList<Reclamation> GetByClientId(int clientId);

		// R�cup�rer les r�clamations par statut (ex: "Nouvelle", "En cours", "R�solue")
		IList<Reclamation> GetByStatut(string statut);
	}
}
