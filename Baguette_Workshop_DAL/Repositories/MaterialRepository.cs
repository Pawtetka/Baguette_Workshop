using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using Baguette_Workshop_DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Baguette_Workshop_DAL.Repositories
{
    public class MaterialRepository : IMaterialRepository<MaterialModel>
    {
        private DbSet<MaterialModel> _dbSet;
        public MaterialRepository(ApplicationContext context)
        {
            _dbSet = context.Set<MaterialModel>();
        }

        public void Add(MaterialModel materialModel)
        {
            _dbSet.Add(materialModel);
        }

        public void DeleteById(int materialModelId)
        {
            var materialModel = _dbSet.Find(materialModelId);

            if (materialModel != null)
            {
                _dbSet.Remove(materialModel);
            }
        }

        public IEnumerable<MaterialModel> GetAll()
        {
            return _dbSet.ToList();
        }

        public MaterialModel GetById(int materialModelId)
        {
            return _dbSet.Find(materialModelId);
        }

        public void Update(MaterialModel materialModel)
        {
            _dbSet.Update(materialModel);
        }
    }
}
