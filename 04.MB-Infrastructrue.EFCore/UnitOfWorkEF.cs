using _00.Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace _04.MB_Infrastructrue.EFCore
{
    public class UnitOfWorkEF : IUnitOfWork
    {
        private readonly MasterBloggerContext dbContext;

        public UnitOfWorkEF(MasterBloggerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void BeginTran()
        {
            dbContext.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            dbContext.SaveChanges();
            dbContext.Database.CommitTransaction();
        }

        public void Rollback()
        {
            dbContext.Database.RollbackTransaction();
        }
    }
}