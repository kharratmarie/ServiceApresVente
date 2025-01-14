namespace ServiceApresVente.Models
{
    public class ArticlePiece
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int Prix { get; set; }

        public int Quantite { get; set; }
    }
}
