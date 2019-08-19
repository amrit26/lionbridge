using Lionbridge.Tasks.Abstract;

namespace Lionbridge.Tasks.Concrete
{
    public class E : IE
    {
        public string RunE()
        {
            return "Run E. No other dependency.";
        }
    }
}
