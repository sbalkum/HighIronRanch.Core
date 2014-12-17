using System;
using System.Linq;

namespace HighIronRanch.Core
{
	public interface IReadModelRepository
	{
		IQueryable<T> Get<T>() where T : IReadModel, new();
		IQueryable<object> Get(Type type);
		T GetById<T>(Guid id) where T : IReadModel, new();
	}
}