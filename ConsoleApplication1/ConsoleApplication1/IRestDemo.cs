using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleApplication1
{
    [ServiceContract(Name = "RestDemo")]
    public interface IRestDemo
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetFoo/{id}", BodyStyle = WebMessageBodyStyle.Bare)]
        string GetFoo(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/GetFooJson?id={id}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        FooBar GetFooJson(string id);

        //[OperationContract]
        //[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/GetFooJsonInput", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //FooBar GetFooJsonInput(FooBar foobar);
    }
}
