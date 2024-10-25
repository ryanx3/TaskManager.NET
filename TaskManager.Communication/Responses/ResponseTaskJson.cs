using TaskManager.Communication.Enums;
namespace TaskManager.Communication.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityEnum Priority { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatusEnum Status { get; set; }
}
