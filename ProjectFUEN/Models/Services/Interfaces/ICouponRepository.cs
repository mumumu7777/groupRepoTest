﻿using ProjectFUEN.Models.DTOs;
using ProjectFUEN.Models.EFModels;

namespace ProjectFUEN.Models.Services.Interfaces
{
    public interface ICouponRepository
    {
        IEnumerable<CouponDto> GetAll(); 

        void Create(CouponDto dto);
    }
}
