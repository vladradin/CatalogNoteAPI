using System;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IRepository<T,T_ID>
    {
        void Add(T addedItem);
        void Remove(T removedItem);
        IEnumerable<T> Get(T_ID itemID);
        IEnumerable<T> GetAll();
    }
}
