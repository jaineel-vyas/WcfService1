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
        // Contract to getting client data
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetClientMaster/")]
        List<ClientMasterContract> GetClientMaster();
    
        // Contract to getting brand data
    [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetBrandMaster/")]
        List<BrandMasterContract> GetBrandMaster();
    
         // Contract to get estimates data
    [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/GetAllEstimate/")]
        List<AddEstimateDataContract> GetAllEstimate();

        // Contract to add new estimate
    [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddNewEstimate/")]
        bool AddNewEstimate(AddEstimateDataContract estimate);

         // Contract to add scheduling
    [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/AddScheduling/")]
        bool AddScheduling(ScheduleDataContract Schedule);
    }
}
