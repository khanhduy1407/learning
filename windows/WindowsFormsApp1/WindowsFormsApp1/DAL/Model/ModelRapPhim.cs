using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Models
{
  public partial class ModelRapPhim : DbContext
  {
    private static ModelRapPhim instance;
    public static ModelRapPhim Instance
    {
      get
      {
        if (instance == null)
          instance = new ModelRapPhim();
        return instance;
      }
      private set
      {
        instance = value;
      }
    }

    public ModelRapPhim()
        : base("name=ModelRapPhim")
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    public virtual DbSet<HoaDon> HoaDons { get; set; }
    public virtual DbSet<KhachHang> KhachHangs { get; set; }
    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<HoaDon>()
          .Property(e => e.TongTien)
          .HasPrecision(9, 0);

      modelBuilder.Entity<HoaDon>()
          .HasMany(e => e.ChiTietHoaDons)
          .WithRequired(e => e.HoaDon)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<KhachHang>()
          .HasMany(e => e.HoaDons)
          .WithRequired(e => e.KhachHang)
          .WillCascadeOnDelete(false);
    }
  }
}
