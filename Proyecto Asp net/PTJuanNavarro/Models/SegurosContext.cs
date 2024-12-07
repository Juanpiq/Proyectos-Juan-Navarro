using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PTJuanNavarro.Models;

public partial class SegurosContext : DbContext
{
    public SegurosContext()
    {
    }

    public SegurosContext(DbContextOptions<SegurosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administradore> Administradores { get; set; }

    public virtual DbSet<Carro> Carros { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ContraseñasAdministradore> ContraseñasAdministradores { get; set; }

    public virtual DbSet<ContraseñasCliente> ContraseñasClientes { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-H9BAB7Q\\SQLEXPRESS;Database=Seguros;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administradore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Administ__3213E83F344ED028");

            entity.HasIndex(e => e.Email, "UQ__Administ__AB6E61647F741D80").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Administradore)
                .HasForeignKey<Administradore>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administrado__id__3F466844");
        });

        modelBuilder.Entity<Carro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carros__3213E83FFFE81C6B");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Cobertura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cobertura");
            entity.Property(e => e.Marca)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.TipoSeguro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_seguro");

            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("costo");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Carros)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Carros_Clientes");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83F00241ED7");

            entity.HasIndex(e => e.Email, "UQ__Clientes__AB6E6164707A65A8").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cotizaciones_Usuarios");
        });

        modelBuilder.Entity<ContraseñasAdministradore>(entity =>
        {
            entity.HasKey(e => e.NombreUsuario).HasName("PK__Contrase__D4D22D758B563E6E");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Contrase__D4D22D7490E7D8D6").IsUnique();

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hash");
            entity.Property(e => e.Salting)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("salting");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithOne(p => p.ContraseñasAdministradore)
                .HasPrincipalKey<Usuario>(p => p.NombreUsuario)
                .HasForeignKey<ContraseñasAdministradore>(d => d.NombreUsuario)
                .HasConstraintName("FK__Contraseñ__nombr__4E88ABD4");
        });

        modelBuilder.Entity<ContraseñasCliente>(entity =>
        {
            entity.HasKey(e => e.NombreUsuario).HasName("PK__Contrase__D4D22D75B59B915C");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Contrase__D4D22D748BC0F712").IsUnique();

            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hash");
            entity.Property(e => e.Salting)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("salting");

            entity.HasOne(d => d.NombreUsuarioNavigation).WithOne(p => p.ContraseñasCliente)
                .HasPrincipalKey<Usuario>(p => p.NombreUsuario)
                .HasForeignKey<ContraseñasCliente>(d => d.NombreUsuario)
                .HasConstraintName("FK__Contraseñ__nombr__4AB81AF0");
        });

        modelBuilder.Entity<Cotizacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cotizaci__3213E83F1F296336");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarroId).HasColumnName("carro_id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.FechaCotizacion).HasColumnName("fecha_cotizacion");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.Carro).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.CarroId)
                .HasConstraintName("FK_Cotizaciones_Carros");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Cotizaciones_Clientes");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3213E83F431B08BC");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuarios__D4D22D74C9DFDBDF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
