using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentPublisherConfig: IEntityTypeConfiguration<FluentPublisher>
    {
        public void Configure(EntityTypeBuilder<FluentPublisher> modelBuilder) 
        {

            modelBuilder.HasKey(u => u.Publisher_Id);
            modelBuilder.Property(u => u.Name).IsRequired();
        }
    }
}
