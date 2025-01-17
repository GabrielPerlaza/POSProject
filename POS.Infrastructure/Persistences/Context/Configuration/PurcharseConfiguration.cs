﻿using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Context.Configuration
{
    public class PurcharseConfiguration : IEntityTypeConfiguration<Purcharse>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Purcharse> builder)
        {
            builder.HasKey(e => e.PurcharseId).HasName("PK__Purchars__A98C674B7EC2E254");

            builder.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Provider).WithMany(p => p.Purcharses)
                .HasForeignKey(d => d.ProviderId)
                .HasConstraintName("FK__Purcharse__Provi__68487DD7");

            builder.HasOne(d => d.User).WithMany(p => p.Purcharses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Purcharse__UserI__693CA210");
        }
    }
}
