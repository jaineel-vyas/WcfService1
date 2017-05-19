using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EstimateService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstimateService1.svc or EstimateService1.svc.cs at the Solution Explorer and start debugging.
    public class EstimateService1 : IEstimateService1
    {
        Jaineelsql2012Entities1 estmodel;

        public EstimateService1()
        {
            estmodel = new Jaineelsql2012Entities1();
        }

        public List<ViewEstimateDataContract> GetAllEstimate()
        {
            var query = (from a in estmodel.EstimateHeaders
                         select a).Distinct();

            List<ViewEstimateDataContract> estimateList = new List<ViewEstimateDataContract>();

            query.ToList().ForEach(rec =>
            {
                estimateList.Add(new ViewEstimateDataContract
                {
                    EstimateNo = rec.EST_NO,
                    PeriodFrom = rec.PeriodForm,
                    PeriodTo = rec.PeriodTo,
                    ClientID = (int)rec.ClientID,
                    BrandID = (int)rec.BrandID,
                    TotalCost = (float)rec.Net_Cost,
                    Status = (int)rec.Status,
                    EditionId = (int)rec.EST_ID
                });
            });
            return estimateList;
        }

        public bool AddNewEstimate(AddEstimateDataContract estimate)
        {
            try
            {
                EstimateHeader esthead = estmodel.EstimateHeaders.Create();
                esthead.EST_NO = estimate.EstimateNo;
                esthead.EST_Date = estimate.EstimateDate;
                esthead.Campaign = estimate.CampaignName;
                esthead.Agency = estimate.AgencyName;
                esthead.PO_NO = estimate.pono;
                esthead.PO_Date = estimate.podate;
                esthead.PeriodForm = estimate.PeriodFrom;
                esthead.PeriodTo = estimate.PeriodTo;
                esthead.SAC_PER = Convert.ToDecimal(estimate.sacper);
                esthead.AAC_PER = Convert.ToDecimal(estimate.aacper);
                esthead.Gross_Cost = 0;
                esthead.Net_Cost = 0;
                esthead.Status = 1;
                //esthead.ClientID = estimate.ClientID;
                //esthead.BrandID = estimate.BrandID;
                esthead.ClientID = 1;
                esthead.BrandID = 1;


                estmodel.EstimateHeaders.Add(esthead);
                estmodel.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return true;
        }

        public List<BrandMasterContract> GetBrandMaster()
        {
            var query = (from a in estmodel.BrandMasters
                         select a).Distinct();

            List<BrandMasterContract> brandlist = new List<BrandMasterContract>();

            query.ToList().ForEach(rec =>
            {
                brandlist.Add(new BrandMasterContract
                {
                    Brand_Name = rec.Brand_Name,
                    BrandID = rec.BrandID

                });
            });
            return brandlist;
        }

        public List<ClientMasterContract> GetClientMaster()
        {
            var query = (from a in estmodel.ClientMasters
                         select a).Distinct();

            List<ClientMasterContract> clientlist = new List<ClientMasterContract>();

            query.ToList().ForEach(rec =>
            {
                clientlist.Add(new ClientMasterContract
                {
                    Client_Name = rec.Client_Name,
                    ClientID = rec.ClientID

                });
            });
            return clientlist;
        }

        public bool AddScheduling(ScheduleDataContract Schedule)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Jaineelsql2012Entities1"].ConnectionString;

            using (SqlConnection con = new SqlConnection("server=(local);database=test;integrated security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddScheduling", con))
                {
                    cmd.Parameters.AddWithValue("@TotalCost", Schedule.TotalCost);
                    cmd.Parameters.AddWithValue("@AgDiscount", Schedule.AgDiscount);
                    cmd.Parameters.AddWithValue("@NetCost", Schedule.NetCost);
                    cmd.Parameters.AddWithValue("@NoOfInser", Schedule.NoOfInser);
                    cmd.Parameters.AddWithValue("@Rate", Schedule.Rate);
                    cmd.Parameters.AddWithValue("@TotalSize", Schedule.TotalSize);
                    cmd.Parameters.AddWithValue("@Height", Schedule.Height);
                    cmd.Parameters.AddWithValue("@Width", Schedule.Width);
                    cmd.Parameters.AddWithValue("@Caption", Schedule.Caption);
                    cmd.Parameters.AddWithValue("@Language", Schedule.Language);
                    cmd.Parameters.AddWithValue("@Schedule", Schedule.SchedleDate);
                    cmd.Parameters.AddWithValue("@EstimateId", Schedule.EstimateId);
                    var n = cmd.ExecuteNonQuery();
                    if (n > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
