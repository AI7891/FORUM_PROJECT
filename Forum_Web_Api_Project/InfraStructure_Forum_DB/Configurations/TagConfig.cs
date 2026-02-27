using Domain_Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Configurations
{
    internal class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            // Table
            builder.ToTable("Tags");

            // Primary Key
            builder.HasKey(t => t.Id)
                .HasName("PK_Tags")
                .IsClustered();

            // Relationships
            builder.HasOne(t => t.Post)
                .WithMany(p => p.Tags)
                .HasForeignKey("PostId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Comment)
                .WithMany(c => c.Tags)
                .HasForeignKey("CommentId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
