using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Clean.Application.Features.Project.Commands.CreateProject;
using Portfolio.Clean.Application.Features.Project.Commands.DeleteProject;
using Portfolio.Clean.Application.Features.Project.Commands.UpdateProject;
using Portfolio.Clean.Application.Features.Project.Queries.GetAllProjects;
using Portfolio.Clean.Application.Features.Project.Queries.GetProjectDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Clean.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProjectsController : ControllerBase
	{

		#region Attributes & Accessors

		private readonly IMediator _mediator;

		#endregion

		#region Constructors
		public ProjectsController(IMediator mediator)
        {
			_mediator = mediator;
		}
        #endregion

        #region Methods
        // GET: api/<ProjectController>
        [HttpGet]
		public async Task<ActionResult<List<ProjectDto>>> Get()
		{
			var projects = await _mediator.Send(new GetProjectsQuery());
			return Ok(projects);
		}

		// GET api/<ProjectController>/FinancialHub
		[HttpGet("{projectName}")]
		public async Task<ActionResult<ProjectDetailsDto>> Get(string projectName)
		{
			var project = await _mediator.Send(new GetProjectDetailsQuery(projectName));
			return Ok(project);
		}

		// POST api/<ProjectController>
		[HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> Post(CreateProjectCommand project)
		{
			var response = await _mediator.Send(project);
			return CreatedAtAction(nameof(Get), new { projectName = response });
		}

		// PUT api/<ProjectController>
		[HttpPut("{projectName}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(400)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult> Put(UpdateProjectCommand project)
		{
			await _mediator.Send(project);
			return NoContent();
		}

		// DELETE api/<ProjectController>/FinancialHub
		[HttpDelete("{projectName}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesDefaultResponseType]
		public async Task<ActionResult> Delete(string projectName)
		{
			var projectToDelete = new DeleteProjectCommand { ProjectName = projectName };
			await _mediator.Send(projectToDelete);
			return NoContent();
		}
		#endregion
	}
}
