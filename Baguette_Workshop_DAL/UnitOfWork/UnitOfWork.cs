using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;

namespace Baguette_Workshop_DAL.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IBaguetteRepository<BaguetteModel> BaguetteRepository { get; set; }
        public IBaguetteMaterialRepository<BaguetteMaterialModel> BaguetteMaterialRepository { get; set; }
        public IMaterialRepository<MaterialModel> MaterialRepository { get; set; }

        public UnitOfWork(ApplicationContext context, IBaguetteRepository<BaguetteModel> baguetteRepository, IBaguetteMaterialRepository<BaguetteMaterialModel> baguetteMaterialRepository,
            IMaterialRepository<MaterialModel> materialRepository)
        {
            _context = context;
            BaguetteRepository = baguetteRepository;
            BaguetteMaterialRepository = baguetteMaterialRepository;
            MaterialRepository = materialRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
