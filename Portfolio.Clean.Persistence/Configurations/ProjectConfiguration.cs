using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Clean.Domain;

namespace Portfolio.Clean.Persistence.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasData(
            new Project
            {
                Id = 1, 
                ProjectName = "This first Project is a test for db initialization",
                ProjectTechnologiesList = "C#,Blazor",
                LastUpdate = DateTime.Now,
                CreationDate = DateTime.Now
            }
        );


    }
    #endregion
}
