﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using ProjectFUEN.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace ProjectFUEN.Models.EFModels
{
    public partial class Event
    {
        public Event()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Display(Name = "活動名稱")]
        [Required(ErrorMessage = "{0} 必填")]
        public string EventName { get; set; }



        [Display(Name = "活動照片")]
        [Required(ErrorMessage = "{0} 必選")]

        public string Photo { get; set; }


        [Display(Name = "開始日期")]
        [DataType(DataType.DateTime, ErrorMessage = "格式有誤")]

        public DateTime StartDate { get; set; }


        [Display(Name = "結束日期")]
        [DataType(DataType.DateTime, ErrorMessage = "格式有誤")]

        public DateTime EndDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public static partial class EventExts
    {
        public static Event ToEntity(this EventVM source)
        {
            return new Event
            {
                Id = source.Id,
                EventName = source.EventName,
                Photo = source.Photo,
                StartDate=source.StartDate,
                EndDate=source.EndDate
            };
        }
    }
}