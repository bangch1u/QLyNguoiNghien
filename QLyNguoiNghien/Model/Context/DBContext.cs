using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QLyNguoiNghien.DomainClass;

namespace QLyNguoiNghien.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NguoiCaiNghien> NguoiCaiNghiens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=BANGCHIU105\\SQLEXPRESS01;Initial Catalog=QLNCN;Integrated Security=True ;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NguoiCaiNghien>(entity =>
        {
            entity.HasKey(e => e.GuidId).HasName("PK__NguoiCai__6EBB7CEE161EF197");

            entity.Property(e => e.GuidId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
