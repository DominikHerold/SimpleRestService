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
    }
}
