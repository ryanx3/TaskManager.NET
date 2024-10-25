using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Create;
using TaskManager.Application.UseCases.Tasks.DeleteById;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetById;
using TaskManager.Application.UseCases.Tasks.UpdateById;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseTaskCreatedJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

    public IActionResult CreateTask([FromBody] RequestTaskJson request)
    {
        var response = new CreateTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll() {
        var response = new GetAllTaskUseCase().Execute();
        if (response.Tasks.Count != 0)
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskByIdUseCase().Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        new DeleteTaskByIdUseCase().Execute(id);
        return NoContent();
    }
}
