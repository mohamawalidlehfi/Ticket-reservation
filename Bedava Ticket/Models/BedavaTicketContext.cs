using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bedava_Ticket.Models;

public partial class BedavaTicketContext : DbContext
{
    public BedavaTicketContext()
    {
        
    }

    public BedavaTicketContext(DbContextOptions<BedavaTicketContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Fatura> Faturas { get; set; }

    public virtual DbSet<Müşteri> Müşteris { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Yolcu> Yolcus { get; set; }

    public virtual DbSet<Ödeme> Ödemes { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ENN26QF;Database=Bedava-Ticket;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Subject).HasMaxLength(50);
        });

        modelBuilder.Entity<Fatura>(entity =>
        {
            entity.ToTable("Fatura");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_name");
            entity.Property(e => e.KimlikNo).HasColumnName("Kimlik_No");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_name");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Müşteri>(entity =>
        {
            entity.ToTable("Müşteri");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dönüş).HasColumnName("dönüş");
            entity.Property(e => e.DönüşZaman).HasColumnName("dönüşZaman");
            entity.Property(e => e.Çocuklar).HasColumnName("çocuklar");
            entity.Property(e => e.Totol).HasColumnName("totol");
           
        });
       
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Passoword).HasMaxLength(50);
        });

        modelBuilder.Entity<Yolcu>(entity =>
        {
            entity.ToTable("Yolcu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.KimlikNo).HasColumnName("Kimlik_No");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_name");
        });

        modelBuilder.Entity<Ödeme>(entity =>
        {
            entity.ToTable("Ödeme");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CardNumber).HasColumnName("Card_Number");
            entity.Property(e => e.Cvv).HasColumnName("CVV");
            entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_Date");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
