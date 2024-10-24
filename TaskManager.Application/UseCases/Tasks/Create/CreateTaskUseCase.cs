using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Create;
public class CreateTaskUseCase
{
    public ResponseTaskCreatedJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskCreatedJson {Id = 1, Title = "Study" };
    }
}
