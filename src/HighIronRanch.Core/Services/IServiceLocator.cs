using System;
using System.Collections.Generic;

namespace HighIronRanch.Core.Services
{
    public interface IServiceLocator
    {
        T GetInstance<T>();
        object GetInstance(Type modelType);
        T TryGetInstance<T>();
        object TryGetInstance(Type modelType);
        IEnumerable<T> GetAllInstances<T>();
        IEnumerable<object> GetAllInstances(Type modelType);
        void BuildUp(object target);
    }
}