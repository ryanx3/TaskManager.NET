using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson {
            Id = id, 
            Title = "Study C#",
            Description = "I need to study C#",
            Deadline = new DateTime(year: 2024, month: 12, day: 1),
            Priority = Communication.Enums.TaskPriorityEnum.High,
            Status = Communication.Enums.TaskStatusEnum.Pending,
        };
    }
}
