using Models.Interfaces;
using Repositories.Interfaces;
using System;

namespace CatalogRepo.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher,Name>
    {

    }
}
