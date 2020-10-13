using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Constants;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Core.Models.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly IContext _context;

        public ReadRepository(
            IContext context)
        {
            _context = context;
        }

        public IResult<IEnumerable<T>> FindAll(
            int skip = AppConstants.DEFAULT_SKIP,
            int take = AppConstants.DEFAULT_TAKE)
            => Do<IEnumerable<T>>.Try(r => _context.Query<T>()
                                                   .Skip(skip)
                                                   .Take(take))
                                 .Result;

        public IResult<IEnumerable<T>> FindAllByFilter(
            Expression<Func<T, bool>> filter,
            int                       skip = AppConstants.DEFAULT_SKIP,
            int                       take = AppConstants.DEFAULT_TAKE) => Do<IEnumerable<T>>.Try(r =>
        {
            var query = _context.Query<T>()
                                .Skip(skip)
                                .Take(take);

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query;
        }).Result;

        public IResult<T> FindById(long id) => Do<T>.Try(r =>
        {
            return _context.Query<T>().First(t => t.Id == id);
;       }).Result;
    }
}
