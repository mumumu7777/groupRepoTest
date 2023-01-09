﻿using ProjectFUEN.Models.DTOs;
using ProjectFUEN.Models.EFModels;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectFUEN.Models.ViewModels
{
    public class ActivityCategoryVM
    {
        public int Id { get; set; }

        [Display(Name = "顯示順序")]
        public int DisplayOrder { get; set; }

        [Display(Name = "類型名稱")]
        public string CategoryName { get; set; }
    }
    public static partial class ActivityCategoryDtoExts
    {
        public static ActivityCategoryVM ToVM(this ActivityCategoryDto source)
        {
            return new ActivityCategoryVM
            {
                Id = source.Id,
                DisplayOrder = source.DisplayOrder,
                CategoryName = source.CategoryName,
            };
        }
    }
}
