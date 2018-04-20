using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Macaria.API.Features.Notes
{
    [Authorize]
    [ApiController]
    [Route("api/notes")]
    public class NotesController
    {
        private readonly IMediator _mediator;

        public NotesController(IMediator mediator) => _mediator = mediator;

        [HttpGet("currentuser")]
        public async Task<ActionResult<GetGetNotesByCurrentUserQuery.Response>> GetByCurrentUser()
            => await _mediator.Send(new GetGetNotesByCurrentUserQuery.Request());

        [HttpPost("{noteId}/tag/{tagId}")]
        public async Task AddTag(AddTagCommand.Request request)
            => await _mediator.Send(request);

        [HttpDelete("{noteId}/tag/{tagId}")]
        public async Task RemoveTag([FromRoute]RemoveTagCommand.Request request)
            => await _mediator.Send(request);

        [HttpPost]
        public async Task<ActionResult<SaveNoteCommand.Response>> Save(SaveNoteCommand.Request request)
            => await _mediator.Send(request);
        

        [HttpGet("title/{title}")]
        public async Task<ActionResult<GetGetNoteByUsernameAndTitleQuery.Response>> GetByTitleAndCurrentUser([FromRoute]GetGetNoteByUsernameAndTitleQuery.Request request)
            => await _mediator.Send(request);

        [HttpDelete("{noteId}")]
        public async Task Remove([FromRoute]RemoveNoteCommand.Request request)
            => await _mediator.Send(request);

        [HttpGet("{noteId}")]
        public async Task<ActionResult<GetNoteByIdQuery.Response>> GetById([FromRoute]GetNoteByIdQuery.Request request)
            => await _mediator.Send(request);

        [HttpGet]
        public async Task<ActionResult<GetNotesQuery.Response>> Get()
            => await _mediator.Send(new GetNotesQuery.Request());
    }
}