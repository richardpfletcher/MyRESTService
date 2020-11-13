using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRESTService" in both code and config file together.
    [ServiceContract]
    public interface IProductRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "GetProductList/")]
        List<CIDR> GetProductList();


        
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Xml,
         BodyStyle = WebMessageBodyStyle.Wrapped,
         UriTemplate = "hello/")]
        IEnumerable<string> HelloData();


    }
}