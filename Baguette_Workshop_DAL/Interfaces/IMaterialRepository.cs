using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface IMaterialRepository<MaterialModel>
    {
        void Add(MaterialModel materialModel);
        void Update(MaterialModel materialModel);
        MaterialModel GetById(int materialModelId);
        void DeleteById(int materialModelId);
        IEnumerable<MaterialModel> GetAll();
    }
}
