using System;
using System.Collections.Generic;
using Clients.Models;
using Microsoft.EntityFrameworkCore;

namespace Clients.Data;

public partial class ClientsContext : DbContext
{
    public ClientsContext(DbContextOptions<ClientsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(250)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni).HasColumnName("dni");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("videos");

            entity.HasIndex(e => e.CliId, "videos_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CliId).HasColumnName("cli_id");
            entity.Property(e => e.Director)
                .HasMaxLength(250)
                .HasColumnName("director");
            entity.Property(e => e.Titulo)
                .HasMaxLength(250)
                .HasColumnName("titulo");

            entity.HasOne(d => d.Cli).WithMany(p => p.Videos)
                .HasForeignKey(d => d.CliId)
                .HasConstraintName("videos_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
