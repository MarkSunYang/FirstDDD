using System;
using System.Collections.Generic;
using System.Text;
using DDD.Repository.Db;

namespace DDD.Repository.EntityFramework
{
    public class EntityFrameworkRepositoryContext : IEntityFrameworkRepositoryContext
    {
        public BookDbContext DbContex => throw new NotImplementedException();
    }
}
