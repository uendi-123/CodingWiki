using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookConfig: IEntityTypeConfiguration<FluentBook>
    {
        public void Configure(EntityTypeBuilder<FluentBook> modelBuilder) 
        {
            modelBuilder.Property(u => u.ISBN).HasMaxLength(50);
            modelBuilder.Property(u => u.ISBN).IsRequired();
            modelBuilder.HasKey(u => u.BookID);
            modelBuilder.Ignore(u => u.PriceRange);
            modelBuilder.HasOne(b => b.Publisher).WithMany(u => u.Books)
                .HasForeignKey(u => u.Publisher_ID);
        }
    }
}
