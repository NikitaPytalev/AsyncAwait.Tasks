using System.Threading.Tasks;

namespace AsyncAwait.Task2.CodeReviewChallenge.Models.Support;

public interface IAssistant
{
    ValueTask<string> RequestAssistanceAsync(string requestInfo);
}
