using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mymdpapp.Infrastructure;

public partial class PasswordsContext : DbContext
{
    public PasswordsContext()
    {
    }

    public PasswordsContext(DbContextOptions<PasswordsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Websity> Websities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Localhost\\SQLEXPRESS;Initial Catalog=Passwords;user=FRPL-ASKAYMERIC\\aymer;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Websity>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
