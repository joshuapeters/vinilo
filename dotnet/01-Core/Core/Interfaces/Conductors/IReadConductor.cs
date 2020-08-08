using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Constants;

namespace Core.Interfaces.Conductors
{
    public interface IReadConductor<T>
    {
        IResult<T>              FindById(long id);
        IResult<IEnumerable<T>> FindAll(int skip = AppConstants.DEFAULT_SKIP, int take = AppConstants.DEFAULT_TAKE);
        IResult<IEnumerable<T>> FindAllWithFilter<TFilter>(TFilter filter, int skip = AppConstants.DEFAULT_SKIP, int take = AppConstants.DEFAULT_TAKE) where TFilter : IFilterParameters;
    }
}
