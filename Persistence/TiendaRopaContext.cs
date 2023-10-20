using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class TiendaRopaContext : DbContext
{
    public TiendaRopaContext(DbContextOptions<TiendaRopaContext> options) : base(options)
    {

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Color> Colores { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<DetalleOrden> DetalleOrdenes { get; set; }
    public DbSet<DetalleVenta> DetalleVentas { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<FormaPago> FormaPagos { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Insumo> Insumos { get; set; }
    public DbSet<InventarioTalla> InventarioTallas { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<InsumoPrenda> InsumoPrendas { get; set; }
    public DbSet<InsumoProveedor> InsumoProveedores { get; set; }
    public DbSet<Municipio> Municipios { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Prenda> Prendas { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Rol> Rols { get; set; }
    public DbSet<Talla> Tallas { get; set; }
    public DbSet<TipoEstado> TipoEstados { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<TipoProteccion> TipoProtecciones { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRol> UserRols { get; set; }
    public DbSet<Venta> Ventas { get; set; }
}
