using System.ServiceModel;
using System.ServiceModel.Activation;

namespace ConsoleApplication1
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestDemo : IRestDemo
    {
        public string GetFoo(string id)
        {
            return string.Format("foo{0}bar", id);
        }
    }
}
