namespace ServiceApresVente.Repositories
{
	public interface IArticlePieceRepository
	{
		// R�cup�rer tous les ArticlePiece
		IList<ArticlePiece> GetAll();

		// R�cup�rer un ArticlePiece par son ID
		ArticlePiece GetById(int id);

		// Ajouter un ArticlePiece
		void Add(ArticlePiece articlePiece);

		// Mettre � jour un ArticlePiece
		void Update(ArticlePiece articlePiece);

		// Supprimer un ArticlePiece par son ID
		void Delete(int id);

		// R�cup�rer tous les ArticlePiece d'un Article
		IList<ArticlePiece> GetByArticleId(int articleId);

	}
}
