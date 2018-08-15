using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DDD.Infrastructure
{
    /// <summary>
    /// 分页结果
    /// </summary>
    public class PagedResult<T> : IEnumerable<T>, ICollection<T>
    {
        public static readonly PagedResult<T> EmptyPagedResult = new PagedResult<T>(0, 0, 0, 0, null);


        #region Public Properties

        // 总记录数
        public int TotalRecords { get; set; }

        // 总页数
        public int TotalPages { get; set; }

        // 每页的记录数
        public int PageSize { get; set; }

        // 页码
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置当前页码的记录
        /// </summary>
        public List<T> PageData { get; set; }

        #endregion

        #region 构造函数

        public PagedResult(){
            this.PageData = new List<T>();
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalRecords">总记录</param>
        /// <param name="totalPages">总页数</param>
        /// <param name="pageSize">页面记录大小</param>
        /// <param name="pageNumber">第几页</param>
        /// <param name="data">数据</param>
        public PagedResult(int totalRecords,int totalPages,int pageSize,int pageNumber, List<T> data)
        {
            this.TotalPages = totalPages;
            this.TotalRecords = totalRecords;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.PageData = data;
        }

        #endregion


        #region IEnumberable Members
        public IEnumerator<T> GetEnumerator()
        {
            return PageData.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return PageData.GetEnumerator();
        }
        #endregion

        #region ICollection Members
        public void Add(T item)
        {
            PageData.Add(item);
        }

        public void Clear()
        {
            PageData.Clear();
        }

        public bool Contains(T item)
        {
            return PageData.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            PageData.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return PageData.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return PageData.Remove(item);
        }
        #endregion 
    }
}
