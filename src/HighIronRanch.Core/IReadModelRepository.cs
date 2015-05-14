using System;
using System.Linq;
using System.Threading.Tasks;

namespace HighIronRanch.Core
{
	public interface IReadModelRepository
	{
		Task<IQueryable<T>> GetAsync<T>() where T : IReadModel, new();
		IQueryable<T> Get<T>() where T : IReadModel, new();

		Task<IQueryable<object>> GetAsync(Type type);
		IQueryable<object> Get(Type type);

		Task<T> GetByIdAsync<T>(Guid id) where T : IReadModel, new();
		T GetById<T>(Guid id) where T : IReadModel, new();
	}
}