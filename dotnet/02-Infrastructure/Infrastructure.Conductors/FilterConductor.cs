using System;
using System.Linq.Expressions;
using Core.Interfaces;
using Core.Interfaces.Conductors;

namespace Infrastructure.Conductors
{
    public class FilterConductor<T> : IFilterConductor<T>
    {
        public Expression<Func<T, bool>> ComposeFilterExpressionFromParameters(IFilterParameters parameters)
        {
            return arg => true;
        }
    }
}
