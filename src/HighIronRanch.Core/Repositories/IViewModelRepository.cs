using System;
using System.Linq;
using System.Threading.Tasks;

namespace HighIronRanch.Core.Repositories
{
    public interface IViewModelRepository
    {
        Task<IQueryable<T>> GetAsync<T>() where T : IViewModel, new();
        IQueryable<T> Get<T>() where T : IViewModel, new();

        Task<T> GetAsync<T>(Guid id) where T : IViewModel, new();
        T Get<T>(Guid id) where T : IViewModel, new();
    }
}