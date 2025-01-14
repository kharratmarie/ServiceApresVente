public interface IArticleRepository
{
    // R�cup�rer tous les articles
    IList<Article> GetAll();

    // R�cup�rer un article par son identifiant
    Article GetById(int id);

    // Ajouter un nouvel article
    void Add(Article article);

    // Mettre � jour un article existant
    void Update(Article article);

    // Supprimer un article par son identifiant
    void Delete(int id);

    // R�cup�rer tous les articles par type
    Article GetByNom(string type);

    // R�cup�rer tous les articles par type
    IList<Article> GetByType(string type);
    // R�cup�rer toutes les r�clamations d'un client
    IList<ArticlePiece> GetArticlePiecesByArticleId(int articleId);
}