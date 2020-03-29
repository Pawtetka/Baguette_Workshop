using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using BLL_new.Classes;

namespace BLL_new.Services
{
    public class MaterialService
    {
        private Mapper _mapper;
        private IUnitOfWork _unitOfWork;
        public MaterialService(Mapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public void AddMaterial(Material material)
        {
            _unitOfWork.MaterialRepository.Add(_mapper.Map<MaterialModel>(material));
        }
    }
}
