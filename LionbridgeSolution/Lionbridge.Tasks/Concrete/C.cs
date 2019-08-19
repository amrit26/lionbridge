using Lionbridge.Tasks.Abstract;

namespace Lionbridge.Tasks.Concrete
{
    public class C : IE, IC
    {
        public string RunC()
        {
            return "Run C.";
        }

        public string RunE()
        {
            return $"Run E then {RunC()}";
        }
    }
}
