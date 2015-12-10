using System;

namespace HighIronRanch.Core.Services
{
    public interface ICollectionNamer
    {
        string GetCollectionName(Type type);
    }
}