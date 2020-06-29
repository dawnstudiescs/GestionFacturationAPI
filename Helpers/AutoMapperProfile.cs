﻿using GestionFacturation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace GestionFacturation.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Utilisateur, UtilisateurModel>();
            CreateMap<UpdateModel, Utilisateur>();
        }
    }
}
