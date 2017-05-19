using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.ServiceModel.Web;

namespace WcfService1
{
    [ServiceContract]
    public interface IEstimateService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetClientMaster/")]
        List<ClientMasterContract> GetClientMaster();
    

    [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetBrandMaster/")]
        List<BrandMasterContract> GetBrandMaster();
    
    
    [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllEstimate/")]
        List<AddEstimateDataContract> GetAllEstimate();
   
    [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddNewEstimate")]
        bool AddNewEstimate(AddEstimateDataContract estimate);

    }
}
