using AutoMapper;
using Portfolio.Clean.BlazorUI.Contracts;
using Portfolio.Clean.BlazorUI.Models.ContactEmails;
using Portfolio.Clean.BlazorUI.Models.Projects;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.Services;

public class ProjectService : BaseHttpService, IProjectService
{


	#region Attributes & Accessors

	private readonly IMapper _mapper;
	#endregion

	#region Constructors
	public ProjectService(IClient client, IMapper mapper)
		:base(client)
    {
		_mapper = mapper;
	}
    #endregion

    #region Methods
    public async Task<Response<Guid>> CreateProject(ProjectVM project)
	{
		try
		{
			var createProjectCommand = _mapper.Map<CreateProjectCommand>(project);
			await _client.ProjectsPOSTAsync(createProjectCommand);	
			return new Response<Guid>()
			{
				Success = true
			};
		}

        catch (ApiException ex)
        {
			return ConvertApiException<Guid>(ex);
		}
	}

	public async Task<Response<Guid>> DeleteProject(string projectName)
	{
		try
		{
			await _client.ProjectsDELETEAsync(projectName);
			return new Response<Guid>()
			{
				Success = true
			};
		}
		catch (ApiException ex)
		{
			return ConvertApiException<Guid>(ex);
		}
	}

	public async Task<ProjectVM> GetProjectDetails(string projectName)
	{
		var project = await _client.ProjectsGETAsync(projectName);
		return _mapper.Map<ProjectVM>(project);
	}

	public async Task<List<ProjectVM>> GetProjects()
	{
		var projects = await _client.ProjectsAllAsync();
		return _mapper.Map<List<ProjectVM>>(projects);
	}

	public async Task<Response<Guid>> UpdateProject(string projectName, ProjectVM project)
	{
		try
		{
			var updateProjectCommand = _mapper.Map<UpdateProjectCommand>(project);
			await _client.ProjectsPUTAsync(projectName, updateProjectCommand);
			return new Response<Guid>()
			{
				Success = true
			};
		}
		catch (ApiException ex)
		{
			return ConvertApiException<Guid>(ex);
		}
	}
	#endregion

}
