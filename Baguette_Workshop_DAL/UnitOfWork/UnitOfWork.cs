using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using Baguette_Workshop_DAL.Repositories;

namespace Baguette_Workshop_DAL.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private IBaguetteRepository<BaguetteModel> _baguetteRepository;
        private IBaguetteMaterialRepository<BaguetteMaterialModel> _baguetteMaterialRepository;
        private IMaterialRepository<MaterialModel> _materialRepository;
        public IBaguetteRepository<BaguetteModel> BaguetteRepository { get { return _baguetteRepository ?? (_baguetteRepository = new BaguetteRepository(_context)); } }
        public IBaguetteMaterialRepository<BaguetteMaterialModel> BaguetteMaterialRepository { get { return _baguetteMaterialRepository ?? (_baguetteMaterialRepository = new BaguetteMaterialRepository(_context)); } }
        public IMaterialRepository<MaterialModel> MaterialRepository { get { return _materialRepository ?? (_materialRepository = new MaterialRepository(_context)); } }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
