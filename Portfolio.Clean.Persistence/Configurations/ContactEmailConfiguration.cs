using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.Configurations;

public class ContactEmailConfiguration : IEntityTypeConfiguration<ContactEmail>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public void Configure(EntityTypeBuilder<ContactEmail> builder)
    {
        builder.HasData(
            new ContactEmail
            {
                Id = 1,
                ContactEmailContent = "This first ContactEmail is a test for db initialization",
                ContactEmailObject = "Initialization test",
                ContactEmailSender = "Configuration",
                ContactEmailIsSent = false,
                LastUpdate = DateTime.Now,
                CreationDate = DateTime.Now
            }
        );
    }
    #endregion

}
