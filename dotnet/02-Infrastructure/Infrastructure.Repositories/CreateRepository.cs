using System.Collections.Generic;
using System.Linq;
using AndcultureCode.CSharp.Core;
using AndcultureCode.CSharp.Core.Interfaces;
using Core.Interfaces.Data;
using Core.Interfaces.Repositories;
using Core.Models.Entities;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
    public class CreateRepository<T> : ICreateRepository<T> where T : EntityBase
    {
        private readonly IContext  _context;
        private readonly ILogger   _logger;
        private readonly DbContext _dbContext;

        public CreateRepository(
            IContext context,
            ILogger  logger
        )
        {
            _context   = context;
            _dbContext = context as DbContext;
            _logger    = logger;
        }

        public IResult<T> Create(T entity) => Do<T>.Try(r =>
        {
            _context.Add(entity);
            _context.DetectChanges(); // Note: New to EF Core, #SaveChanges, #Add and other methods do NOT automatically call DetectChanges
            _context.SaveChanges();

            return entity;
        }).Result;


        public IResult<IEnumerable<T>> BulkCreate(IEnumerable<T> entities) => Do<IEnumerable<T>>.Try(r =>
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();

            var bulkStrategy = new BulkConfig
            {
                BatchSize = 1000,
                PreserveInsertOrder = true,
                SetOutputIdentity = true,
                UseTempDB = true
            };

            strategy.Execute(
                _dbContext,
                operation =>
                {
                    using (var transaction = _dbContext.Database.BeginTransaction())
                    {
                        _dbContext.BulkInsert(entities.ToList(), bulkStrategy);
                        transaction.Commit();
                    }
                }
            );

            return entities;
        }).Result;
    }
}
