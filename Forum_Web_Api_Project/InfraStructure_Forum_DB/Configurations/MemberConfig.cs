using Domain_Forum.Enums;
using Domain_Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Configurations
{
    internal class MemberConfig
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            // Table
            builder.ToTable("Members");

            // Primary Key
            builder.HasKey(m => m.Id)
                .HasName("PK_Members")
                .IsClustered();

            // Properties
            builder.Property(m => m.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m => m.Password)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(m => m.Email)
                .HasMaxLength(255)
                .IsUnicode()
                .IsRequired();

            builder.Property(m => m.Role)
                .HasConversion<string>()
                .HasDefaultValue(MemberRole.User)
                .HasMaxLength(20)
                .HasSentinel(0)
                .IsRequired();

        }
    }
}
