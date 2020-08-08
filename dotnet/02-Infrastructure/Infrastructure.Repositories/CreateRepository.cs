using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
    public class CreateRepository<T> : ICreateRepository<T>
    {
        private readonly IViniloContext _context;
        private readonly ILogger        _logger;

        public CreateRepository(
            IViniloContext context,
            ILogger        logger
        )
        {
            _context = context;
            _logger  = logger;
        }

        public IResult<T> Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IResult<IEnumerable<T>> BulkCreate(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}
