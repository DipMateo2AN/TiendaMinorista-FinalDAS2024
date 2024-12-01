using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ProductoImportado> ProductosImportados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=TiendaMinoristaDB;");

        protected override void OnModelCreating(ModelBuilder model)
        {
            // Configurar las tablas y claves primarias
            model.Entity<Categoria>().ToTable("Categoria").HasKey(c => c.Id);
            model.Entity<Cliente>().ToTable("Cliente").HasKey(c => c.Id);
            model.Entity<DetalleFactura>().ToTable("DetalleFactura").HasKey(c => c.Id);
            model.Entity<Factura>().ToTable("Factura").HasKey(f => f.Id);
            model.Entity<Producto>().ToTable("Producto").HasKey(p => p.Id);
            model.Entity<Proveedor>().ToTable("Proveedor").HasKey(p => p.Id);
            model.Entity<ProductoImportado>().ToTable("ProductoImportado").HasBaseType<Producto>();

            // Configurar relaciones muchos-a-muchos
                
            model.Entity<Proveedor>()
                .HasMany(p => p.Productos)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "ProveedorProducto", // Tabla intermedia
                    j => j.HasOne<Producto>()
                          .WithMany()
                          .HasForeignKey("ProductoId")
                          .OnDelete(DeleteBehavior.Cascade),
                    j => j.HasOne<Proveedor>()
                          .WithMany()
                          .HasForeignKey("ProveedorId")
                          .OnDelete(DeleteBehavior.Restrict)); // Evitar eliminación en cascada

  
              

            // Configurar relaciones uno-a-muchos o muchos-a-uno
            model.Entity<Factura>()
                .HasOne(f => f.Cliente)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada

            model.Entity<DetalleFactura>()
                .HasOne(d => d.Factura)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<DetalleFactura>()
                .HasOne(d => d.Producto)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}