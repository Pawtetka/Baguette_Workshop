using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Baguette_Workshop_DAL.Models;

namespace BLL_new.Classes
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BaguetteModel, Baguette>().ReverseMap();
            CreateMap<MaterialModel, Material>().ReverseMap();
            CreateMap<BaguetteMaterialModel, BaguetteMaterial>().ReverseMap();
        }
    }
}
