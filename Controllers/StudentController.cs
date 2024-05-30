using Microsoft.AspNetCore.Mvc;
using testC__API.Domains.Dtos;
using testC__API.Domains;

namespace testC__API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<CreateStudentResponse>> PostStudentAsync
        (
            [FromServices] IStudentInteractor interactor,
            [FromBody] CreateStudentRequest request
        )
        {
            var studentItem = await interactor.CreateStudentInfoAsync(request);
            if(studentItem == null )
            {
                return BadRequest();
            }
            return Ok(studentItem);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetStudentResponse>>> GetStudentListAsync
        (
            [FromServices] IStudentInteractor interactor
        )
        {
            var studentList = await interactor.GetStudentListAsync();
            if(studentList == null )
            {
                return NotFound();
            }
            return Ok(studentList);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<GetStudentResponse>> GetStudentAsync
        (
            [FromServices] IStudentInteractor interactor,
            [FromRoute] Guid id
        )
        {
            var studentItem = await interactor.GetStudentAsync(id);
            if(studentItem == null)
            {
                return NotFound();
            }
            return Ok(studentItem);
        }
    }
}
