using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Constants;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
    public class ReadRepository<T> : IReadRepository<T>
    {
        private readonly IViniloContext _context;
        private readonly ILogger        _logger;

        public ReadRepository(
            IViniloContext context,
            ILogger        logger
        )
        {
            _context = context;
            _logger  = logger;
        }

        public IResult<IEnumerable<T>> FindAll(
            int skip = AppConstants.DEFAULT_SKIP,
            int take = AppConstants.DEFAULT_TAKE) => Do<IEnumerable<T>>.Try(r =>
        {
            throw new System.NotImplementedException();
        })
        .Result;

        public IResult<IEnumerable<T>> FindAllByFilter(
            Expression<Func<T, bool>> filter,
            int                       skip = AppConstants.DEFAULT_SKIP,
            int                       take = AppConstants.DEFAULT_TAKE) => Do<IEnumerable<T>>.Try(r =>
        {
            throw new System.NotImplementedException();
        })
        .Result;

        public IResult<T> FindById(long id) => Do<T>.Try(r =>
        {
            throw new System.NotImplementedException();
        })
        .Result;
    }
}
