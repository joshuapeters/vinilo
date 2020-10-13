using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Interfaces;

namespace Core.Interfaces.Repositories
{
    public interface ICreateRepository<T>
    {
        IResult<T>              Create(T                  entity);
        IResult<IEnumerable<T>> BulkCreate(IEnumerable<T> entities);
    }
}
