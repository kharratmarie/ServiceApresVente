using ServiceApresVente.Models;

namespace ServiceApresVente.Repositories
{
    public interface IInterventionRepository
    {
        // Récupérer toutes les interventions
        IList<Intervention> GetAll();

        // Récupérer une intervention par son ID
        Intervention GetById(int id);

        // Ajouter une intervention
        void Add(Intervention intervention);

        // Mettre à jour une intervention
        void Update(Intervention intervention);

        // Supprimer une intervention par son ID
        void Delete(int id);

        // Récupérer les interventions par réclamation
        IList<Intervention> GetByReclamationId(int reclamationId);

        // Récupérer les interventions sous garantie
        IList<Intervention> GetByGarantie(bool sousGarantie);
    }
}
