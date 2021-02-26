using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        public DbContext Context { get; private set; }
        private IDbContextTransaction Transaction { get; set; }

        public UnitOfWork()
        {
            Context = new MyDbContext();
        }

        public void BeginTransaction()
        {
            Transaction = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            Transaction.Commit();
        }

        public void Rollback()
        {
            Transaction.Rollback();
        }

        public void Dispose()
        {
            Context.Dispose();
            Transaction.Dispose();
        }
    }
}
