using System.Collections.Generic;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Extensions;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Constants;
using Core.Interfaces;
using Core.Interfaces.Conductors;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Conductors
{
    public class ReadConductor<T> : IReadConductor<T>
    {
        private readonly ILogger             _logger;
        private readonly IReadRepository<T>  _readRepository;
        private readonly IFilterConductor<T> _filterConductor;

        public ReadConductor(
            ILogger            logger,
            IReadRepository<T> readRepository
        )
        {
            _logger         = logger;
            _readRepository = readRepository;
        }

        public IResult<T> FindById(long id) => Do<T>.Try(r =>
        {
            var result = _readRepository.FindById(id);

            if (result.HasErrorsOrResultIsNull())
            {
                r.AddErrors(result);
                return default(T);
            }

            return result.ResultObject;
        })
        .Result;

        public IResult<IEnumerable<T>> FindAll(
            int skip = AppConstants.DEFAULT_SKIP,
            int take = AppConstants.DEFAULT_TAKE
        ) => Do<IEnumerable<T>>.Try(r =>
        {
            var result = _readRepository.FindAll(skip, take);

            if (result.HasErrorsOrResultIsNull())
            {
                r.AddErrors(result);
                return default(IEnumerable<T>);
            }

            return result.ResultObject;
        })
        .Result;

        public IResult<IEnumerable<T>> FindAllWithFilter<TFilter>(
            TFilter filter,
            int     skip = AppConstants.DEFAULT_SKIP,
            int     take = AppConstants.DEFAULT_TAKE
        ) where TFilter : IFilterParameters => Do<IEnumerable<T>>.Try(r =>
        {
            var filterExpression = _filterConductor.ComposeFilterExpressionFromParameters(filter);
            var result           = _readRepository.FindAllByFilter(filterExpression, skip, take);

            if (result.HasErrorsOrResultIsNull())
            {
                r.AddErrors(result);
                return default(IEnumerable<T>);
            }

            return result.ResultObject;
        })
        .Result;
    }
}
