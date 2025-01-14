public interface IArticleRepository
{
    // Récupérer tous les articles
    IList<Article> GetAll();

    // Récupérer un article par son identifiant
    Article GetById(int id);

    // Ajouter un nouvel article
    void Add(Article article);

    // Mettre à jour un article existant
    void Update(Article article);

    // Supprimer un article par son identifiant
    void Delete(int id);

    // Récupérer tous les articles par type
    Article GetByNom(string type);

    // Récupérer tous les articles par type
    IList<Article> GetByType(string type);
    // Récupérer toutes les réclamations d'un client
    IList<ArticlePiece> GetArticlePiecesByArticleId(int articleId);
}