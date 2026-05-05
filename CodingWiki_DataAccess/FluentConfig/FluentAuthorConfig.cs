using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentAuthorConfig: IEntityTypeConfiguration<FluentAuthor>
    {
        public void Configure(EntityTypeBuilder<FluentAuthor> modelBuilder) 
        {
            modelBuilder.HasKey(u => u.Author_Id);
            modelBuilder.Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Property(u => u.FirstName).IsRequired();
            modelBuilder.Property(u => u.LastName).IsRequired();
            modelBuilder.Ignore(u => u.FullName);
        }
    }
}
