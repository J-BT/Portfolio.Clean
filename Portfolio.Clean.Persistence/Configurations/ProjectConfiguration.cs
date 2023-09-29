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
				ProjectTitleFr = "Projet Test",
				ProjectTitleEn = "Test Project",
				ProjectTitleJp = "テストプロジェクト",
                ProjectTechnologies = "C#,Blazor",
				ProjectDescriptionFr = "La base de données fonctionne",
				ProjectDescriptionEn = "The database is working",
				ProjectDescriptionJp = "データベースが発動されました",
				LastUpdate = DateTime.Now,
                CreationDate = DateTime.Now
            }
        );


    }
    #endregion
}
