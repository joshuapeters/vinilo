using System.Collections.Generic;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Extensions;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Interfaces.Conductors;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Conductors
{
    public class CreateConductor<T> : ICreateConductor<T>
    {
        private readonly ICreateRepository<T> _createRepository;

        public CreateConductor(ICreateRepository<T> createRepository)
        {
            _createRepository = createRepository;
        }

        public IResult<T> Create(T entity) => Do<T>.Try(r =>
        {
            var result = _createRepository.Create(entity);

            if (result.HasErrorsOrResultIsNull())
            {
                r.AddErrors(result.Errors);
                return default(T);
            }

            return result.ResultObject;
        }).Result;

        public IResult<IEnumerable<T>> BulkCreate(IEnumerable<T> entities) => Do<IEnumerable<T>>.Try(r =>
        {
            var result = _createRepository.BulkCreate(entities);

            if (result.HasErrorsOrResultIsNull())
            {
                r.AddErrors(result.Errors);
                return null;
            }

            return result.ResultObject;
        }).Result;
    }
}
