using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighIronRanch.Core
{
	public interface IWritableReadModelRepository : IReadModelRepository
	{
		Task InsertAsync<T>(IEnumerable<T> items) where T : IReadModel;
		void Insert<T>(IEnumerable<T> items) where T : IReadModel;

		Task SaveAsync<T>(T item) where T : IReadModel;
		void Save<T>(T item) where T : IReadModel;

		Task DeleteAsync<T>(T item) where T : IReadModel;
		void Delete<T>(T item) where T : IReadModel;

		Task TruncateAsync<T>() where T : IReadModel;
		void Truncate<T>() where T : IReadModel;
	}
}