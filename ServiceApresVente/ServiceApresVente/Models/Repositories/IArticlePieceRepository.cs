namespace ServiceApresVente.Repositories
{
	public interface IArticlePieceRepository
	{
		// Récupérer tous les ArticlePiece
		IList<ArticlePiece> GetAll();

		// Récupérer un ArticlePiece par son ID
		ArticlePiece GetById(int id);

		// Ajouter un ArticlePiece
		void Add(ArticlePiece articlePiece);

		// Mettre à jour un ArticlePiece
		void Update(ArticlePiece articlePiece);

		// Supprimer un ArticlePiece par son ID
		void Delete(int id);

		// Récupérer tous les ArticlePiece d'un Article
		IList<ArticlePiece> GetByArticleId(int articleId);

	}
}
