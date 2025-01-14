namespace ServiceApresVente.Models
{
    public class Reclamation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }
        public string Statut { get; set; } // "Nouvelle", "En cours", "Résolue"
        public DateTime Date { get; set; }
    }
}
