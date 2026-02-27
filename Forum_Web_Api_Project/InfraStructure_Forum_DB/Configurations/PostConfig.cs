using Domain_Forum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraStructure_Forum_DB.Configurations
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {
            #region Table Name
            builder.ToTable("Posts");
            #endregion

            #region Primary Key
            builder.HasKey(x => x.Id)
                   .IsClustered()
                   .HasName("PK_Posts_Id");
            #endregion

            #region Columns
            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.MemberId)
                   .IsRequired()
                   .HasColumnType("int")
                   .HasConversion<string>();
            #endregion
            /*
             *      public int Id { get; private set; }
                    public Member MemberId { get; private set; }

                    public DateTime CreationDate { get; private set; } = DateTime.Now;
                    public string Subject { get; private set; }

                    public string Body { get; private set; } = string.Empty;

                    public IEnumerable<Comment> Comments { get; private set; } = [];
                    public IEnumerable<Like> Likes { get; private set; } = [];

                    public IEnumerable<Tag> Tags { get; private set; } = [];
             */
        }
    }
}
