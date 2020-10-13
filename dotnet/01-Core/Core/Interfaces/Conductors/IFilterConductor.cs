using System;
using System.Linq.Expressions;

namespace Core.Interfaces.Conductors
{
    public interface IFilterConductor<T>
    {
        Expression<Func<T, bool>> ComposeFilterExpressionFromParameters(IFilterParameters parameters);
    }
}
