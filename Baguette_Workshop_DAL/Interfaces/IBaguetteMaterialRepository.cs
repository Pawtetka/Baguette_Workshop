using Baguette_Workshop_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface IBaguetteMaterialRepository<BaguetteMaterialModel> 
    {
        void Add(BaguetteMaterialModel baguetteMaterialModel);
        void Update(BaguetteMaterialModel bagueteMaterialModel);
        BaguetteMaterialModel GetById(int baguetteMaterialModelId);
        void DeleteById(int baguetteMaterialModelId);
        IEnumerable<BaguetteMaterialModel> GetAll();
    }
}
