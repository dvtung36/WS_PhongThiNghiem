namespace WSPhongThiNghiem.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LabRoomEntity : DbContext
    {
        public LabRoomEntity()
            : base("name=LabRoomEntity")
        {
        }

        public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<PhieuDangKiKhaiThac> PhieuDangKiKhaiThacs { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.ChiTietPhieuMuons)
                .WithRequired(e => e.PhieuMuon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThietBi>()
                .HasMany(e => e.ChiTietPhieuMuons)
                .WithRequired(e => e.ThietBi)
                .WillCascadeOnDelete(false);
        }
    }
}
