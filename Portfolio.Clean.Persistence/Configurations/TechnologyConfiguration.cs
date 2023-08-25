using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.Configurations;

public class TechnologyConfiguration : IEntityTypeConfiguration<Technology>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public void Configure(EntityTypeBuilder<Technology> builder)
    {
        builder.HasData(
            new Technology
            {
                Id = 1,
                TechnoName = "This first Technology is a test for db initialization", 
                CreationDate = DateTime.Now,
                LastUpdate = DateTime.Now

            }
        );
    }
    #endregion
}
