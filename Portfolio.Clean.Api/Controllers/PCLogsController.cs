using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Clean.Application.Features.PCLog.Commands.CreatePCLog;
using Portfolio.Clean.Application.Features.PCLog.Commands.DeletePCLog;
using Portfolio.Clean.Application.Features.PCLog.Commands.UpdatePCLog;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetAllPCLogs;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetPCLogDetails;
using Portfolio.Clean.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCLogsController : ControllerBase
    {

        #region Attributes & Accessors

        private readonly IMediator _mediator;

        #endregion

        #region Constructors
        public PCLogsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        // GET: api/<PCLogsController>
        [HttpGet]
        public async Task<ActionResult<List<PCLogDto>>> Get()
        {
            var pcLogs = await _mediator.Send(new GetPCLogsQuery());
            return Ok(pcLogs);
        }

        // GET api/<PCLogsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PCLogDetailsDto>> Get(int id)
        {
            var pcLog = await _mediator.Send(new GetPCLogDetailsQuery(id));
            return Ok(pcLog);
        }

        // POST api/<PCLogsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(CreatePCLogCommand pCLog)
        {
            var response = await _mediator.Send(pCLog);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<PCLogsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdatePCLogCommand pCLog)
        {
            await _mediator.Send(pCLog);
            return NoContent();
        }

        // DELETE api/<PCLogsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var pcLogToDelete = new DeletePCLogCommand { Id = id };
            await _mediator.Send(pcLogToDelete);
            return NoContent();
        }
        #endregion
    }
}
