﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace YazılımGercekleme.Models.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasDefaultValue("No info.");

            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Computer Science" },
                new Category { CategoryId = 2, CategoryName = "Classic" },
                new Category { CategoryId = 3, CategoryName = "Literature" }
            );
        }
    }
}
