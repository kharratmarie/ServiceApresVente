using ServiceApresVente.Models;

namespace ServiceApresVente.Repositories
{
    public interface IInterventionRepository
    {
        // R�cup�rer toutes les interventions
        IList<Intervention> GetAll();

        // R�cup�rer une intervention par son ID
        Intervention GetById(int id);

        // Ajouter une intervention
        void Add(Intervention intervention);

        // Mettre � jour une intervention
        void Update(Intervention intervention);

        // Supprimer une intervention par son ID
        void Delete(int id);

        // R�cup�rer les interventions par r�clamation
        IList<Intervention> GetByReclamationId(int reclamationId);

        // R�cup�rer les interventions sous garantie
        IList<Intervention> GetByGarantie(bool sousGarantie);
    }
}
