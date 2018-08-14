using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DDD.Domain.Repositories
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : class
    {


        #region 数据库操作

        void Add(TAggregateRoot aggregateRoot);

        TAggregateRoot GetByKey(Guid key);

        /// <summary>
        /// 读取所有聚合根
        /// </summary>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortPredicate"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> GetAll(Expression<Func<TAggregateRoot, dynamic>> sortPredicate, 
            SortOrder sortOrder);

        #endregion
    }
}
