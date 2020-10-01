namespace WSPhongThiNghiem.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDangKiKhaiThac")]
    public partial class PhieuDangKiKhaiThac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuDangKy { get; set; }

        public int? MaGV { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        [StringLength(50)]
        public string MonHoc { get; set; }

        [StringLength(50)]
        public string BaiThiNghiem { get; set; }

        public DateTime? ThoiGian { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
