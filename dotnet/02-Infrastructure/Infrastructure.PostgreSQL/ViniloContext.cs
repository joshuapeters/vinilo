using System;
using Core.Interfaces.Data;
using Core.Models.Entities.Albums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.PostgreSQL
{
    public class ViniloContext :  Context, IViniloContext
    {
        #region PRIVATE MEMBERS

        private readonly string _connectionString;

        #endregion

        #region PUBLIC DBSETS

        public DbSet<Album> Albums { get; set; }

        #endregion

        public ViniloContext(string connectionString) : base(connectionString) {}
    }
}
