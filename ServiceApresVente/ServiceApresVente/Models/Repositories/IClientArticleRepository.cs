namespace ServiceApresVente.Repositories
{
    public interface IClientArticleRepository
    {
        // R�cup�rer tous les ClientArticle
        IList<ClientArticle> GetAll();

        // R�cup�rer un ClientArticle par son ID
        ClientArticle GetById(int id);

        // Ajouter un ClientArticle
        void Add(ClientArticle clientArticle);

        // Mettre � jour un ClientArticle
        void Update(ClientArticle clientArticle);

        // Supprimer un ClientArticle par son ID
        void Delete(int id);

        // R�cup�rer tous les articles achet�s par un client
        IList<ClientArticle> GetByClientId(int clientId);

        // R�cup�rer tous les clients ayant achet� un article
        IList<ClientArticle> GetByArticleId(int articleId);
    }
}
