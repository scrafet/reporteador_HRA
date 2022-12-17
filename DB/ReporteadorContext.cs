using Microsoft.EntityFrameworkCore;

namespace DB;

public class ReporteadorContext : DbContext
{
    public ReporteadorContext(DbContextOptions<DbContext> options)
        :base(options)
    {
        
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Grupo> Grupos  { get; set; }
    public DbSet<Rol> Roles  { get; set; }
    public DbSet<Reporte> Reportes { get; set; }
    public DbSet<Asignacion> Asignaciones { get; set; }
    public DbSet<Menu> Menus  { get; set; }
    public DbSet<Permiso> Permisos  { get; set; }
    public DbSet<PermisoAsignacion> PermisoAsignaciones  { get; set; }
    public DbSet<Estado> Estados  { get; set; }
    public DbSet<AdminLog> AdminLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("Usuario");
        modelBuilder.Entity<Grupo>().ToTable("Grupo");
        modelBuilder.Entity<Rol>().ToTable("Rol");
        modelBuilder.Entity<Reporte>().ToTable("Reporte");
        modelBuilder.Entity<Asignacion>().ToTable("Asignacion");
        modelBuilder.Entity<Menu>().ToTable("Menu");
        modelBuilder.Entity<Permiso>().ToTable("Permiso");
        modelBuilder.Entity<PermisoAsignacion>().ToTable("PermisoAsignacion");
        modelBuilder.Entity<Estado>().ToTable("Estado");
        modelBuilder.Entity<AdminLog>().ToTable("AdminLog");
    }
}