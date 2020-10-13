using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Constants;

namespace Core.Interfaces.Repositories
{
    public interface IReadRepository<T>
    {
        IResult<IEnumerable<T>> FindAll(
            int skip = AppConstants.DEFAULT_SKIP,
            int take = AppConstants.DEFAULT_TAKE);

        IResult<IEnumerable<T>> FindAllByFilter(
            Expression<Func<T, bool>> filter,
            int                       skip = AppConstants.DEFAULT_SKIP,
            int                       take = AppConstants.DEFAULT_TAKE);

        IResult<T> FindById(long id);
    }
}
