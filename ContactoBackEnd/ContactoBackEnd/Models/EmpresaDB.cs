namespace ContactoBackEnd.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmpresaDB : DbContext
    {
        public EmpresaDB()
            : base("name=EmpresaDB")
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Direccion_1)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Direccion_2)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);
        }
    }
}
