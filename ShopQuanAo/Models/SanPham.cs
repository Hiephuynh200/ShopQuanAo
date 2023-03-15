namespace ShopQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string HinhAnh { get; set; }

        public int? MaLoai { get; set; }

        public double? GiaBan { get; set; }

        public int? SoLuong { get; set; }

        public double? GiaNhap { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
