using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RepositoReplicado
{
    public partial class HospitalDbContext : DbContext
    {
        public HospitalDbContext()
        {
        }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctore> Doctores { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Hospitale> Hospitales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=STEVENPC\\SQLDEVELOPER;Initial Catalog=HospitalDb; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.HasIndex(e => e.EspecialidadId, "IX_Doctores_EspecialidadId");

                entity.HasIndex(e => e.HospitalId, "IX_Doctores_HospitalId")
                    .IsUnique();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.Doctores)
                    .HasForeignKey(d => d.EspecialidadId);

                entity.HasOne(d => d.Hospital)
                    .WithOne(p => p.Doctore)
                    .HasForeignKey<Doctore>(d => d.HospitalId);
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.Property(e => e.NombreEspecialidad).HasColumnName("nombre_Especialidad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
