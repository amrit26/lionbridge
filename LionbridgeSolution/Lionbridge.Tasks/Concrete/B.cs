using Lionbridge.Tasks.Abstract;

namespace Lionbridge.Tasks.Concrete
{
    public class B : IE, ID
    {
        public string RunD()
        {
            return "Run D.";
        }

        public string RunE()
        {
            return "Run E.";
        }
    }
}
