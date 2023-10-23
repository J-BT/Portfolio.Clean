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
                ProjectName = "test1",
                ProjectTitleFr = "Projet Test",
                ProjectTitleEn = "Test Project",
                ProjectTitleJp = "テストプロジェクト",
                ProjectTechnologies = "csharp,blazor, webassembly, html, css, iis",
                ProjectDescriptionFr = "La base de données fonctionne",
                ProjectDescriptionEn = "The database is working",
                ProjectDescriptionJp = "データベースが発動されました",
                LastUpdate = DateTime.Now,
                CreationDate = DateTime.Now
            },
            new Project
            {
                Id = 2,
                ProjectName = "test2",
                ProjectTitleFr = "Projet Test 2",
                ProjectTitleEn = "Test Project 2",
                ProjectTitleJp = "テストプロジェクト 2",
                ProjectTechnologies = "Csharp, Typescript, Angular, HTML, CSS, IIS",
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
