﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Context.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(e => e.ProviderId).HasName("PK__Provider__B54C687DA696CA26");

            builder.Property(e => e.DocumentNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.Phone).HasMaxLength(15);

            builder.HasOne(d => d.DocumentType).WithMany(p => p.Providers)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Providers__Docum__6477ECF3");
        }
    }
}
