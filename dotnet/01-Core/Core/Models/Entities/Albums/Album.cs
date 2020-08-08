using Core.Models.Entities;

namespace Core.Models.Entities.Albums
{
    public class Album : EntityBase
    {
        public string Name { get; set; }
        public string CatalogId { get; set; }
    }
}
