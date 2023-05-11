using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyProject.MODEL;

namespace MyProject.DAL.DBContextProjeto;

public partial class CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext : DbContext
{
    public CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext()
    {
    }

    public CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext(DbContextOptions<CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Henku\\source\\repos\\Av2Projeto\\MyProject.DAL\\database\\DatabaseProjeto.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROJETO__3214EC074EB1B990");

            entity.ToTable("PROJETO");

            entity.Property(e => e.FinalProjeto).HasColumnType("datetime");
            entity.Property(e => e.InicioProjeto).HasColumnType("datetime");
            entity.Property(e => e.NomeDoGerente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomeDoProjeto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResumoProjeto)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.StatusProjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
