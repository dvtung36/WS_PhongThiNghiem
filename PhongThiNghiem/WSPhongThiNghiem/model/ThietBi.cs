namespace WSPhongThiNghiem.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThietBi")]
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi(int v)
        {
            ChiTietPhieuMuons = new HashSet<ChiTietPhieuMuon>();
        }

        public ThietBi(int v, string v1, string v2, string v3) : this(v)
        {
            this.MaTB = v;
            this.TenTB = v1;
            this.ChungLoai = v2;
            this.PhanMem=v3;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTB { get; set; }

        [StringLength(50)]
        public string TenTB { get; set; }

        [StringLength(50)]
        public string ChungLoai { get; set; }

        [StringLength(50)]
        public string PhanMem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}
