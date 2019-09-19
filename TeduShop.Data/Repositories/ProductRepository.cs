using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
	public interface IProductRepository:IRepository<Product>
	{
	}

	public class ProductRepository : RepositoryBase<Product>, IProductRepository
	{
		public ProductRepository(DbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}