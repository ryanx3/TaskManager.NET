using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            { new ResponseShortTaskJson {
                Id = 1,
                Description = "Lorem ipsum",
                Title = "Study english"
                },
                new ResponseShortTaskJson {
                Id = 2,
                Description = "Iskad ifsem",
                Title = "Study french"
                },

            }
        };
        
    }
}
