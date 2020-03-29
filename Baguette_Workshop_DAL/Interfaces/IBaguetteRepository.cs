using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    public interface IBaguetteRepository<BaguetteModel>
    {
        void Add(BaguetteModel baguetteModel);
        void Update(BaguetteModel baguetteModel);
        BaguetteModel GetById(int baguetteModelId);
        void DeleteById(int baguetteModelId);
        IEnumerable<BaguetteModel> GetAll();
    }
}
