using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopQuanAo.Models
{
    public partial class MyDataContextDB : DbContext
    {
        public MyDataContextDB()
            : base("name=MyDataContextDB1")
        {
        }

        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<DonDatHang> DonDatHang { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);
        }
    }
}
