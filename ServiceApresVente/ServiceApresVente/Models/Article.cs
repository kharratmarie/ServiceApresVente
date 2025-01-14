namespace ServiceApresVente.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public ICollection<ArticlePiece> ArticlePieces { get; set; }

    }

}
