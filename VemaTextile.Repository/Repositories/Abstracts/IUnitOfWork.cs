using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.core.Database;
using VemaTextile.Entity.Entity;

namespace VemaTextile.Repository.Repositories.Abstracts
{
    
        public interface IUnitOfWork : IDisposable
        {
            bool Commit();
            IRepository<T> GetRepo<T>() where T : EntityBase, new();
            void Dispose(bool disposing);

        }
    
}
