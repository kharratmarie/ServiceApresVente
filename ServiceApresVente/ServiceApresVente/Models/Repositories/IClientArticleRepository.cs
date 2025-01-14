namespace ServiceApresVente.Repositories
{
    public interface IClientArticleRepository
    {
        // Récupérer tous les ClientArticle
        IList<ClientArticle> GetAll();

        // Récupérer un ClientArticle par son ID
        ClientArticle GetById(int id);

        // Ajouter un ClientArticle
        void Add(ClientArticle clientArticle);

        // Mettre à jour un ClientArticle
        void Update(ClientArticle clientArticle);

        // Supprimer un ClientArticle par son ID
        void Delete(int id);

        // Récupérer tous les articles achetés par un client
        IList<ClientArticle> GetByClientId(int clientId);

        // Récupérer tous les clients ayant acheté un article
        IList<ClientArticle> GetByArticleId(int articleId);
    }
}
