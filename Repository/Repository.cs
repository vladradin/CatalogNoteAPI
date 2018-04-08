
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class Repository<T, T_ID> : IRepository<T, T_ID>
        where T : Entity<T_ID>
        where T_ID : IEquatable<T_ID>
    {
        protected DbSet<T> _entities;

        public Repository(DbSet<T> entitiesSet) => _entities = entitiesSet;

        public void Add(T itemToAdd) => _entities.Add(itemToAdd);

        public IEnumerable<T> Get(T_ID itemID) => _entities.Where(entity => entity.Id.Equals(itemID));

        public IEnumerable<T> GetAll() => _entities.ToList();

        public void Remove(T removedItem) => _entities.Remove(removedItem);
    }
}
