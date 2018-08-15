using DDD.Infrastructure;
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

        /// <summary>
        /// 根据聚合根的ID值，从仓储中读取聚合根
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TAggregateRoot GetByKey(Guid key);

        /// <summary>
        /// 读取所有聚合根
        /// </summary>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> GetAll();

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="sortPredicate"></param>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        IEnumerable<TAggregateRoot> GetAll(Expression<Func<TAggregateRoot, dynamic>> sortPredicate, 
            SortOrder sortOrder);

        void Remove(TAggregateRoot aggregateRoot);

        void Update(TAggregateRoot aggregateRoot);

        PagedResult<TAggregateRoot> GetAll(Expression<Func<TAggregateRoot, dynamic>> sortPredicate,
          SortOrder sortOrder, int pageNumber, int pageSize);

        #endregion
    }
}
