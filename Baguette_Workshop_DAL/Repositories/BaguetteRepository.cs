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
    class BaguetteRepository : IBaguetteRepository<BaguetteModel>
    {
        private DbSet<BaguetteModel> _dbSet;
        public BaguetteRepository(ApplicationContext context)
        {
            _dbSet = context.Set<BaguetteModel>();
        }

        public void Add(BaguetteModel baguetteModel)
        {
            _dbSet.Add(baguetteModel);
        }

        public void DeleteById(int baguetteModelId)
        {
            var baguetteModel = _dbSet.Find(baguetteModelId);

            if (baguetteModel != null)
            {
                _dbSet.Remove(baguetteModel);
            }
        }

        public IEnumerable<BaguetteModel> GetAll()
        {
            return _dbSet.ToList();
        }

        public BaguetteModel GetById(int baguetteModelId)
        {
            return _dbSet.Find(baguetteModelId);
        }

        public void Update(BaguetteModel baguetteModel)
        {
            _dbSet.Update(baguetteModel);
        }
    }
}
