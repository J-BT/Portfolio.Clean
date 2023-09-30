using System.ComponentModel.DataAnnotations;

namespace Portfolio.Clean.BlazorUI.Models.Projects;

public class ProjectVM
{
	#region Attributes & Accessors
	public int Id { get; set; }

	[Required]
	public string ProjectName { get; set; } = string.Empty;
	public string? ProjectTitleFr { get; set; } = string.Empty;
	public string? ProjectTitleEn { get; set; } = string.Empty;
	public string? ProjectTitleJp { get; set; } = string.Empty;
	[Required]
	public string ProjectTechnologies { get; set; } = string.Empty;
	public string? ProjectDescriptionFr { get; set; } = string.Empty;
	public string? ProjectDescriptionEn { get; set; } = string.Empty;
	public string? ProjectDescriptionJp { get; set; } = string.Empty;
	public string? ProjectUrl { get; set; }
	public string? ProjectVideo { get; set; }
	public string? ProjectGithub { get; set; }
	#endregion

	#region Constructors

	#endregion

	#region Methods

	#endregion
}
