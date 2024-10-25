using TaskManager.Communication.Requests;

namespace TaskManager.Communication.Responses;
public class ResponseAllTaskJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}
