using Baguette_Workshop_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface IUnitOfWork
    {
        IBaguetteRepository<BaguetteModel> BaguetteRepository { get; }
        IBaguetteMaterialRepository<BaguetteMaterialModel> BaguetteMaterialRepository { get; }
        IMaterialRepository<MaterialModel> MaterialRepository { get; }
        void Save();
    }
}
