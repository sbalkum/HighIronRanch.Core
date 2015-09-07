using System.Collections.Generic;
using System.Threading.Tasks;

namespace HighIronRanch.Core.Repositories
{
    public interface IWritableViewModelRepository : IViewModelRepository
    {
        Task InsertAsync<T>(T items) where T : IViewModel;
        void Insert<T>(T items) where T : IViewModel;
        Task InsertAsync<T>(IEnumerable<T> items) where T : IViewModel;
        void Insert<T>(IEnumerable<T> items) where T : IViewModel;

        Task SaveAsync<T>(T item) where T : IViewModel;
        void Save<T>(T item) where T : IViewModel;

        Task DeleteAsync<T>(T item) where T : IViewModel;
        void Delete<T>(T item) where T : IViewModel;

        Task TruncateAsync<T>() where T : IViewModel;
        void Truncate<T>() where T : IViewModel;
    }
}