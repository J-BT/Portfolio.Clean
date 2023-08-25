using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.Configurations;

public class PCLogConfiguration : IEntityTypeConfiguration<PCLog>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public void Configure(EntityTypeBuilder<PCLog> builder)
    {
        builder.HasData(
            new PCLog
            {
                Id = 1,
                PCLogContent = "This first PCLog is a test for db initialization",
                LastUpdate = DateTime.Now,
                CreationDate = DateTime.Now
            }
        );


    }
    #endregion
}
