using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Interfaces;

namespace Core.Interfaces.Conductors
{
    public interface ICreateConductor<T>
    {
        IResult<T>              Create(T entity);
        IResult<IEnumerable<T>> BulkCreate(IEnumerable<T> entities);
    }
}
