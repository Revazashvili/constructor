
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
                        builder.ToTable("TEST","dbo");
                                     builder.HasKey(x => x.Id).HasName("ID");
                                                builder.Property(x => x.FirstName)
                    .HasColumnName("FIRSTNAME")
                    .HasPrecision(1,2)
                    .IsRequired().HasMaxLength(20).IsUnicode();
                        builder.Property(x => x.LastName)
                    .HasColumnName("LASTNAME")
                    .HasPrecision(1,2)
                    .IsRequired().HasMaxLength(12);
                        builder.Property(x => x.Test2Id)
                    .HasColumnName("TEST2_ID")
                    .HasPrecision(1,2)
                    .IsRequired().HasMaxLength(12);
                                    builder.HasOne(x => x.Test2)
                    .WithOne(x => x.Test)
                    .HasForeignKey<Test>(x => x.Test2Id)
                    .OnDelete(DeleteBehavior.NoAction);
                    }
    }
}


