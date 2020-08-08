using System;
using Core.Interfaces.Data;
using Core.Models.Entities.Albums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.PostgreSQL
{
    public class ViniloContext :  DbContext, IViniloContext
    {
        #region PRIVATE MEMBERS

        private readonly string _connectionString;

        #endregion

        #region PUBLIC DBSETS

        public DbSet<Album> Albums { get; set; }

        #endregion

        public ViniloContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString, options => options.EnableRetryOnFailure(3, TimeSpan.FromSeconds(30), null));
        }
    }
}
