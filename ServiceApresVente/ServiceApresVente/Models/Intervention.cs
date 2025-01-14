namespace ServiceApresVente.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public int ReclamationId { get; set; }
        public Reclamation Reclamation { get; set; }
        public bool SousGarantie { get; set; }
        public decimal CoutMainOeuvre { get; set; }
        public decimal CoutPieces { get; set; }
        public decimal MontantTotal => SousGarantie ? 0 : CoutMainOeuvre + CoutPieces;
        public string Statut { get; set; } // "En cours", "Terminée"
    }

}
