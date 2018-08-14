using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.WorkofUnit
{
    /// <summary>
    /// 领域实体接口
    /// </summary>
    public class IEntity
    { 
        // 当前领域实体的全局唯一标识
        Guid Id { get; }
    }
}
