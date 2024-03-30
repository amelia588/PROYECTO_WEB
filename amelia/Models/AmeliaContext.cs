using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace amelia.Models;

public partial class AmeliaContext : DbContext
{
    public AmeliaContext()
    {
    }

    public AmeliaContext(DbContextOptions<AmeliaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\senati; database=AMELIA; integrated security=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3214EC274423E122");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Cargo).HasMaxLength(50);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
