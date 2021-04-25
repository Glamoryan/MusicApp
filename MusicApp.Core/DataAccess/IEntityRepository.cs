using MusicApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MusicApp.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T Entity);
        T Update(T Entity);
        void Delete(T Entity);
    }
}
