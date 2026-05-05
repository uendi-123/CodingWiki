using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookAuthorMapConfig: IEntityTypeConfiguration<FluentBookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<FluentBookAuthorMap> modelBuilder) 
        {
            modelBuilder.HasKey(u => new { u.Author_Id, u.Book_Id });
            modelBuilder.HasOne(b => b.Book).WithMany(u => u.BookAuthorMap)
                .HasForeignKey(u => u.Book_Id);
            modelBuilder.HasOne(b => b.Author).WithMany(u => u.BookAuthorMap)
                .HasForeignKey(u => u.Author_Id);
        }
    }
}
