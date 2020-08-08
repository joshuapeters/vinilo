using Core.Models.Entities.Albums;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces.Data
{
    public interface IViniloContext
    {
        DbSet<Album> Albums { get; set; }
    }
}
