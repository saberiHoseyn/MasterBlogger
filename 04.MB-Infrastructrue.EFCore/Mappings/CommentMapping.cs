﻿using _01.MB.Domin.CommenntAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _04.MB_Infrastructrue.EFCore.Mappings
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Email);
            builder.Property(x => x.Message);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.ArticleId);

            builder.HasOne(x => x.Article).WithMany(x => x.Comments)
                   .HasForeignKey(x => x.ArticleId);
        }
    }
}
