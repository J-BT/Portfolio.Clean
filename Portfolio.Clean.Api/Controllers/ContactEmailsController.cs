using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetContactEmailDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Clean.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactEmailsController : ControllerBase
{

    #region Attributes & Accessors

    private readonly IMediator _mediator;

    #endregion

    #region Constructors
    public ContactEmailsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    #endregion

    #region Methods

    // GET: api/<ContactEmailsController>
    [HttpGet]
    public async Task<List<ContactEmailDto>> Get()
    {
        var contactEmails = await _mediator.Send(new GetContactEmailsQuery());
        return contactEmails;
    }

    // GET api/<ContactEmailsController>/5
    [HttpGet("{id}")]
    public async Task<ContactEmailDetailsDto> Get(int id)
    {
        var contactEmail = await _mediator.Send(new GetContactEmailDetailsQuery(id));
        return contactEmail;
    }

    // POST api/<ContactEmailsController>
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Post(CreateContactEmailCommand contactEmail)
    {
        var response = await _mediator.Send(contactEmail);
        return CreatedAtAction(nameof(Get), new { id = response});
    }

    // PUT api/<ContactEmailsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ContactEmailsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
    #endregion
}
