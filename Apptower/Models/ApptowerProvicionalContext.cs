using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Apptower.Models;

public partial class ApptowerProvicionalContext : IdentityDbContext
{
    public ApptowerProvicionalContext()
    {
    }

    public ApptowerProvicionalContext(DbContextOptions<ApptowerProvicionalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Espacio> Espacios { get; set; }

    public virtual DbSet<Parqueadero> Parqueaderos { get; set; }

    public virtual DbSet<ParqueaderosDeEspacio> ParqueaderosDeEspacios { get; set; }

    public virtual DbSet<Propietario> Propietarios { get; set; }

    public virtual DbSet<PropietariosPorEspacio> PropietariosPorEspacios { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<ReservasEspacio> ReservasEspacios { get; set; }

    public virtual DbSet<ReservasParqueadero> ReservasParqueaderos { get; set; }

    public virtual DbSet<Residente> Residentes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<VehiculosPorEspacio> VehiculosPorEspacios { get; set; }

    public virtual DbSet<Visitante> Visitantes { get; set; }

    public virtual DbSet<VisitantesPorEspacio> VisitantesPorEspacios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=EMMANUEL-2021-U;Initial Catalog=ApptowerProvicional;integrated security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Espacio>(entity =>
        {
            entity.HasKey(e => e.IdEspacio).HasName("PKIdEspacios");

            entity.HasIndex(e => e.NombreEspacio, "UQ__Espacios__585163C086FD1B28").IsUnique();

            entity.Property(e => e.EstadoEspacio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')");
            entity.Property(e => e.NombreEspacio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoEspacio)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Parqueadero>(entity =>
        {
            entity.HasKey(e => e.IdParqueadero).HasName("PKParqueaderos");

            entity.HasIndex(e => e.NombreParqueadero, "UNNombreParqueadro").IsUnique();

            entity.Property(e => e.EstadoParqueadero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')");
            entity.Property(e => e.NombreParqueadero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoParqueadero)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ParqueaderosDeEspacio>(entity =>
        {
            entity.HasKey(e => e.IdParqueaderosDeEspacios).HasName("PKParqueaderosDeEspacios");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.ParqueaderosDeEspacios)
                .HasForeignKey(d => d.IdEspacio)
                .HasConstraintName("FKIdEspacio");

            entity.HasOne(d => d.IdParqueaderoNavigation).WithMany(p => p.ParqueaderosDeEspacios)
                .HasForeignKey(d => d.IdParqueadero)
                .HasConstraintName("FKIdParqueaderos");
        });

        modelBuilder.Entity<Propietario>(entity =>
        {
            entity.HasKey(e => e.IdPropietario).HasName("PKIdPropietario");

            entity.Property(e => e.ApellidoPropietario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoPropietario)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPropietario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')");
            entity.Property(e => e.FechaNacimientoPropietario).HasColumnType("datetime");
            entity.Property(e => e.NombrePropietario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumentoPropietario)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoPropietario)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumentoPropietario)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PropietariosPorEspacio>(entity =>
        {
            entity.HasKey(e => e.IdPropietariosPorEspacio).HasName("PKPropietariosPorEspacio");

            entity.ToTable("PropietariosPorEspacio");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.PropietariosPorEspacios)
                .HasForeignKey(d => d.IdEspacio)
                .HasConstraintName("FKEspacios3");

            entity.HasOne(d => d.IdPropietarioNavigation).WithMany(p => p.PropietariosPorEspacios)
                .HasForeignKey(d => d.IdPropietario)
                .HasConstraintName("FKPropietarios3");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("PKReserva");

            entity.Property(e => e.EspacioReserva)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TipoReserva)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FKUsuario");
        });

        modelBuilder.Entity<ReservasEspacio>(entity =>
        {
            entity.HasKey(e => e.IdReservaEspacios).HasName("PKReservaEspacios");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.ReservasEspacios)
                .HasForeignKey(d => d.IdEspacio)
                .HasConstraintName("FKEspacio1");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.ReservasEspacios)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FKReserva1");
        });

        modelBuilder.Entity<ReservasParqueadero>(entity =>
        {
            entity.HasKey(e => e.IdReservaEspacios).HasName("PKReservaParqueadero");

            entity.ToTable("ReservasParqueadero");

            entity.HasOne(d => d.IdParqueaderoNavigation).WithMany(p => p.ReservasParqueaderos)
                .HasForeignKey(d => d.IdParqueadero)
                .HasConstraintName("FKParqueadero2");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.ReservasParqueaderos)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FKReserva2");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.ReservasParqueaderos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FKVehiculo");
        });

        modelBuilder.Entity<Residente>(entity =>
        {
            entity.HasKey(e => e.IdResidente).HasName("PKIdResidente");

            entity.Property(e => e.ApellidoResidente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoResidente)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.EstadoResidente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')");
            entity.Property(e => e.FechaFinResidencia).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioResidencia).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimientoResidente).HasColumnType("datetime");
            entity.Property(e => e.NombreResidente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumentoResidente)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ResidenciaActual)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.TelefonoResidente)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumentoResidente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoResidente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('PROPIETARIO')");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.Residentes)
                .HasForeignKey(d => d.IdEspacio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKEspacio");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PkIdUsuario");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')")
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            base.OnModelCreating(modelBuilder);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PKVehiculos");

            entity.HasIndex(e => e.Placa, "UCPlaca").IsUnique();

            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehiculosPorEspacio>(entity =>
        {
            entity.HasKey(e => e.IdVehiculosPorEspacio).HasName("PKIdVehiculosPorEspacio");

            entity.ToTable("VehiculosPorEspacio");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.VehiculosPorEspacios)
                .HasForeignKey(d => d.IdEspacio)
                .HasConstraintName("FKEspacios2");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.VehiculosPorEspacios)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FKVehiculo2");
        });

        modelBuilder.Entity<Visitante>(entity =>
        {
            entity.HasKey(e => e.IdVisitante).HasName("PKIdVisitante");

            entity.Property(e => e.ApellidoVisitante)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GeneroVisitante)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('OTRO')");
            entity.Property(e => e.NombreVisitante)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumentoVisitante)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PermisoVisitante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('ACTIVO')");
            entity.Property(e => e.TipoDocumentoVisitante)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VisitantesPorEspacio>(entity =>
        {
            entity.HasKey(e => e.IdVisitantePorEspacio).HasName("PKIdVisitantePorEspacio");

            entity.ToTable("VisitantesPorEspacio");

            entity.HasOne(d => d.IdEspacioNavigation).WithMany(p => p.VisitantesPorEspacios)
                .HasForeignKey(d => d.IdEspacio)
                .HasConstraintName("FKEspacios1");

            entity.HasOne(d => d.IdVisitanteNavigation).WithMany(p => p.VisitantesPorEspacios)
                .HasForeignKey(d => d.IdVisitante)
                .HasConstraintName("FKVisitante1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
