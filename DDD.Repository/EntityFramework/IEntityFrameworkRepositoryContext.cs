using DDD.Repository.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Repository.EntityFramework
{
    public interface IEntityFrameworkRepositoryContext
    {
        BookDbContext DbContex { get; }
    }
}
