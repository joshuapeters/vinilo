using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Interfaces.Conductors;

namespace Infrastructure.Conductors
{
    public class CreateConductor<T> : ICreateConductor<T>
    {
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
