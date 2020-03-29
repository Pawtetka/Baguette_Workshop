using AutoMapper;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using BLL_new.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Services
{
    public class BaguetteMaterialService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        public BaguetteMaterialService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public Dictionary<Material, int> GetMaterialsByBaguette(int id)
        {
            var materials = new Dictionary<Material, int>();
            var baguetteMaterials = _mapper.Map<List<BaguetteMaterial>>(_unitOfWork.BaguetteMaterialRepository.GetAll());
            foreach(BaguetteMaterial bagMat in baguetteMaterials)
            {
                if (bagMat.BaguetteModel.Id == id)
                {
                    materials.Add(/*bagMat.MaterialModel*/_mapper.Map<Material>(_unitOfWork.MaterialRepository.GetById(bagMat.MaterialModelId)), bagMat.Quantity);
                }
            }
            return materials;
        }
        public void AddBaguetteMaterial(BaguetteMaterial baguetteMaterial)
        {
            var baguetteModel = _mapper.Map<BaguetteMaterialModel>(baguetteMaterial);
            baguetteModel.BaguetteModel = _mapper.Map<BaguetteModel>(baguetteMaterial.BaguetteModel);
            baguetteModel.MaterialModel = _mapper.Map<MaterialModel>(baguetteMaterial.MaterialModel);
            _unitOfWork.BaguetteMaterialRepository.Add(/*_mapper.Map<BaguetteMaterialModel>(baguetteMaterial)*/baguetteModel);
        }
    }
}
