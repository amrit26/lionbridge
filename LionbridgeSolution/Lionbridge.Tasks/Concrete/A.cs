using Lionbridge.Tasks.Abstract;

namespace Lionbridge.Tasks.Concrete
{
    public class A : IAllTasksExceptE
    {
        public string RunAllTasksExceptE()
        {
            return "All tasks but ran, except E.";
        }
    }
}
