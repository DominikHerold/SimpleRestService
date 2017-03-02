using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

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

        public FooBar GetFooJson(string id)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            return new FooBar { Id = id, IsFoo = true };
        }

        public FooBar GetFooJsonInput(FooBar foobar)
        {
            return new FooBar { Id = foobar.Id, IsFoo = foobar.IsFoo, IsBar = foobar.IsBar };
        }
    }
}
