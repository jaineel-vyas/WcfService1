using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class AddEstimateDataContract
    {
        [DataMember]
        public string EstimateNo { get; set; }

        [DataMember]
        public DateTime EstimateDate { get; set; }

        [DataMember]
        public string CampaignName { get; set; }

        [DataMember]
        public string AgencyName { get; set; }

        [DataMember]
        public DateTime PeriodFrom { get; set; }

        [DataMember]
        public DateTime PeriodTo { get; set; }

        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public int BrandID { get; set; }

        [DataMember]
        public string pono { get; set; }

        [DataMember]
        public float sacper { get; set; }

        [DataMember]
        public float aacper { get; set; }

        [DataMember]
        public DateTime podate { get; set; }
    }
    [DataContract]
    public class ClientMasterContract
    {
        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public string Client_Name { get; set; }
    }

    [DataContract]
    public class BrandMasterContract
    {
        [DataMember]
        public int BrandID { get; set; }

        [DataMember]
        public string Brand_Name { get; set; }
    }

    [DataContract]
    public class ScheduleDataContract
    {
        [DataMember]
        public DateTime SchedleDate { get; set; }

        [DataMember]
        public string Caption { get; set; }

        [DataMember]
        public string Language { get; set; }

        [DataMember]
        public float Height { get; set; }

        [DataMember]
        public float Width { get; set; }

        [DataMember]
        public float TotalSize { get; set; }

        [DataMember]
        public float Rate { get; set; }

        [DataMember]
        public int NoOfInser { get; set; }

        [DataMember]
        public float TotalCost { get; set; }

        [DataMember]
        public float AgDiscount { get; set; }

        [DataMember]
        public float NetCost { get; set; }

        [DataMember]
        public int EstimateId { get; set; }

    }
}
[DataContract]
public class ViewEstimateDataContract
{
    [DataMember]
    public string EstimateNo { get; set; }

    [DataMember]
    public DateTime PeriodFrom { get; set; }

    [DataMember]
    public DateTime PeriodTo { get; set; }

    [DataMember]
    public int ClientID { get; set; }

    [DataMember]
    public int BrandID { get; set; }

    [DataMember]
    public float TotalCost { get; set; }

    [DataMember]
    public int Status { get; set; }

    [DataMember]
    public int EditionId { get; set; }
}