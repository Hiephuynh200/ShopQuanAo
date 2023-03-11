namespace ShopQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonDatHang")]
    public partial class DonDatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDDH { get; set; }

        public int? MaSP { get; set; }

        public int? MaNV { get; set; }

        public int? MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDatHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
