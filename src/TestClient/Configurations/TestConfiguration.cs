
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestClient.Entities
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("TEST", "dbo");
            builder.HasKey(x => x.Id).HasName("ID");
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasPrecision(0, 0)
                .IsRequired();
            builder.Property(x => x.FirstName)
                .HasColumnName("FIRSTNAME")
                .HasPrecision(1, 2)
                .IsRequired().HasMaxLength(20).IsUnicode();
            builder.Property(x => x.LastName)
                .HasColumnName("LASTNAME")
                .HasPrecision(1, 2)
                .IsRequired().HasMaxLength(12);
            builder.Property(x => x.CustomerId)
                .HasColumnName("CUSTOMER_ID")
                .HasPrecision(1, 2)
                .IsRequired().HasMaxLength(12);
            builder.HasOne(x => x.Customer)
                .WithOne(x => x.Test)
                .HasForeignKey<Test>(x => x.CustomerId)
                .IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.CustomerResponses)
                .WithMany(x => x.Tests);
        }
    }
}


