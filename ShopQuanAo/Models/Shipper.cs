namespace ShopQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipper")]
    public partial class Shipper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaShipper { get; set; }

        [StringLength(50)]
        public string TenShipper { get; set; }

        public int? SDT { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string CongTy { get; set; }
    }
}
