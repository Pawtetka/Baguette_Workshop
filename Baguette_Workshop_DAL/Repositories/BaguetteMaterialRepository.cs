using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using Baguette_Workshop_DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Baguette_Workshop_DAL.Repositories
{
    public class BaguetteMaterialRepository : IBaguetteMaterialRepository<BaguetteMaterialModel>
    {
        private DbSet<BaguetteMaterialModel> _dbSet;
        public BaguetteMaterialRepository(ApplicationContext context)
        {
            _dbSet = context.Set<BaguetteMaterialModel>();
        }

        public void Add(BaguetteMaterialModel baguetteMaterialModel)
        {
            _dbSet.Add(baguetteMaterialModel);
        }

        public void DeleteById(int baguetteMaterialModelId)
        {
            var baguetteMaterialModel = _dbSet.Find(baguetteMaterialModelId);

            if (baguetteMaterialModel != null)
            {
                _dbSet.Remove(baguetteMaterialModel);
            }
        }

        public IEnumerable<BaguetteMaterialModel> GetAll()
        {
            return _dbSet.ToList();
        }

        public BaguetteMaterialModel GetById(int baguetteMaterialModelId)
        {
            return _dbSet.Find(baguetteMaterialModelId);
        }

        public void Update(BaguetteMaterialModel baguetteMaterialModel)
        {
            _dbSet.Update(baguetteMaterialModel);
        }
    }
}
