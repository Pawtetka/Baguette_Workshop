using Baguette_Workshop_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface IUnitOfWork
    {
        IBaguetteRepository<BaguetteModel> BaguetteRepository { get; }
        IBaguetteMaterialRepository<BaguetteMaterialModel> BaguetteMaterialRepository { get; set; }
        IMaterialRepository<MaterialModel> MaterialRepository { get; set; }
        void Save();
    }
}
