using AutoMapper;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Models;
using BLL_new.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Services
{
    public class BaguetteService
    {
        private Mapper _mapper;
        private IUnitOfWork _unitOfWork;
        public BaguetteService(Mapper mapper, IUnitOfWork unitOfWork) 
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public List<Baguette> GetAllBaguettes()
        {
            return _mapper.Map<List<Baguette>>(_unitOfWork.BaguetteRepository.GetAll());
        }
        public void AddBaguette(Baguette baguette)
        {
            _unitOfWork.BaguetteRepository.Add(_mapper.Map<BaguetteModel>(baguette));
        }
    }
}
