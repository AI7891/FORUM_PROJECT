using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain_Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Configurations
{
    internal class CommentConfig: IEntityTypeConfiguration<Comment>
    {
       public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.ToTable("Comments");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Content).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.CreatedAt)
                .IsRequired();

            builder.Property(c => c.IsReported)
                .HasDefaultValue(false);

            builder.Property(c => c.EditedBy)
                .HasMaxLength(50);

            builder.HasOne(c => c.Member)
                .WithMany()
                .HasForeignKey(c => c.MemberId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
