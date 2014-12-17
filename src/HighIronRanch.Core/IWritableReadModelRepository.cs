using System;
using System.Collections.Generic;

namespace HighIronRanch.Core
{
	public interface IWritableReadModelRepository : IReadModelRepository
	{
		void Insert<T>(IEnumerable<T> items) where T : IReadModel;
		void Save<T>(T item) where T : IReadModel;
		void Delete<T>(T item) where T : IReadModel;
		void Truncate<T>() where T : IReadModel;
		void BulkSetProperty<T>(IEnumerable<Guid> ids, string propertyName, object value) where T : IReadModel;
	}
}