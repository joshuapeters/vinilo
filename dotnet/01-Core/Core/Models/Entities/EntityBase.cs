using System;
using AndcultureCode.CSharp.Core.Interfaces.Entity;

namespace Core.Models.Entities
{
    public class EntityBase : IEntity, ICreatable, IUpdatable, IDeletable
    {
        public long            Id          { get; set; }

        public long?           CreatedById { get; set; }
        public DateTimeOffset? CreatedOn   { get; set; }

        public long?           UpdatedById { get; set; }
        public DateTimeOffset? UpdatedOn   { get; set; }

        public long?           DeletedById { get; set; }
        public DateTimeOffset? DeletedOn   { get; set; }
    }
}
