using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookDetailConfig: IEntityTypeConfiguration<FluentBookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentBookDetail> modelBuilder) 
        {
            //name of table
            
            modelBuilder.ToTable("Fluent_BookDetails");

            //name of columns
            modelBuilder.Property(u => u.NumberOfChapters).HasColumnName("NoOfChapters");

            //prymary key
            modelBuilder.HasKey(u => u.BookDetail_Id);

            //other validations
            modelBuilder.Property(u => u.NumberOfChapters).IsRequired();

            //relationships
            modelBuilder.HasOne(b => b.Book).WithOne(b => b.BookDetail)
                .HasForeignKey<FluentBookDetail>(u => u.Book_ID);
        }
    }
}
