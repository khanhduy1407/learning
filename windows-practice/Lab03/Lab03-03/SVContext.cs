using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab03_03
{
  public partial class SVContext : DbContext
  {
    public SVContext()
        : base("name=SVContext")
    {
    }

    public virtual DbSet<SV> SVs { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SV>()
          .Property(e => e.MaSV)
          .IsUnicode(false);
    }
  }
}
