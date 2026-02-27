using Domain_Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Configurations
{
    internal class LikeConfig : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            // Table
            builder.ToTable("Likes");

            // Primary Key
            builder.HasKey(l => l.Id)
                .HasName("PK_Likes")
                .IsClustered();

            // Properties
            builder.Property(l => l.IsLiked)
                .IsRequired();

            // Relationships
            builder.HasOne(l => l.Post)
                .WithMany(p => p.Likes)
                .HasForeignKey("PostId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Comment)
                .WithMany(c => c.Likes)
                .HasForeignKey("CommentId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
