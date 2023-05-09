﻿using FotballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Username)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.Password)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.Balance)
                .IsRequired();
        }
    }
}
