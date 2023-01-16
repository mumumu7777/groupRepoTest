﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProjectFUEN.Models.EFModels
{
    public partial class Member
    {
        public Member()
        {
            ActivityCollections = new HashSet<ActivityCollection>();
            ActivityMembers = new HashSet<ActivityMember>();
            Albums = new HashSet<Album>();
            CommentReports = new HashSet<CommentReport>();
            Comments = new HashSet<Comment>();
            FollowInfoFollowerNavigations = new HashSet<FollowInfo>();
            FollowInfoFollowingNavigations = new HashSet<FollowInfo>();
            OrderDetails = new HashSet<OrderDetail>();
            OthersCollections = new HashSet<OthersCollection>();
            OwnCollections = new HashSet<OwnCollection>();
            PhotoReports = new HashSet<PhotoReport>();
            Photos = new HashSet<Photo>();
            Questions = new HashSet<Question>();
            ShoppingCarts = new HashSet<ShoppingCart>();
            Views = new HashSet<View>();
            Coupons = new HashSet<Coupon>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string EmailAccount { get; set; }
        public string EncryptedPassword { get; set; }
        public string RealName { get; set; }
        public string NickName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PhotoSticker { get; set; }
        public string About { get; set; }
        public string ConfirmCode { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsInBlackList { get; set; }

        public virtual ICollection<ActivityCollection> ActivityCollections { get; set; }
        public virtual ICollection<ActivityMember> ActivityMembers { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<CommentReport> CommentReports { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FollowInfo> FollowInfoFollowerNavigations { get; set; }
        public virtual ICollection<FollowInfo> FollowInfoFollowingNavigations { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OthersCollection> OthersCollections { get; set; }
        public virtual ICollection<OwnCollection> OwnCollections { get; set; }
        public virtual ICollection<PhotoReport> PhotoReports { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public virtual ICollection<View> Views { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}