﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KHODMEntities : DbContext
    {
        public KHODMEntities()
            : base("name=KHODMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTDH> CTDHs { get; set; }
        public virtual DbSet<CTPN> CTPNs { get; set; }
        public virtual DbSet<CTPX> CTPXes { get; set; }
        public virtual DbSet<CTSUCO> CTSUCOes { get; set; }
        public virtual DbSet<CTTK> CTTKs { get; set; }
        public virtual DbSet<CTYCX> CTYCXes { get; set; }
        public virtual DbSet<CUAHANG> CUAHANGs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHUs { get; set; }
        public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SUCO> SUCOes { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }
        public virtual DbSet<YCXUAT> YCXUATs { get; set; }
    }
}