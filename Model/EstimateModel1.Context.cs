﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Jaineelsql2012Entities1 : DbContext
    {
        public Jaineelsql2012Entities1()
            : base("name=Jaineelsql2012Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BrandMaster> BrandMasters { get; set; }
        public DbSet<CaptionMaster> CaptionMasters { get; set; }
        public DbSet<ClientMaster> ClientMasters { get; set; }
        public DbSet<EstimateEdition> EstimateEditions { get; set; }
        public DbSet<EstimateHeader> EstimateHeaders { get; set; }
        public DbSet<EstimatePublication> EstimatePublications { get; set; }
        public DbSet<EstimateScheduled> EstimateScheduleds { get; set; }
    
        public virtual int sp_CreateEstimateProc(string estimateno, Nullable<System.DateTime> estimatedate, string campaignName, string agencyName, Nullable<System.DateTime> periodFrom, Nullable<System.DateTime> periodTo, Nullable<int> clientid, Nullable<int> brandid, string pono, Nullable<decimal> sacper, Nullable<decimal> aacper, Nullable<System.DateTime> podate)
        {
            var estimatenoParameter = estimateno != null ?
                new ObjectParameter("Estimateno", estimateno) :
                new ObjectParameter("Estimateno", typeof(string));
    
            var estimatedateParameter = estimatedate.HasValue ?
                new ObjectParameter("Estimatedate", estimatedate) :
                new ObjectParameter("Estimatedate", typeof(System.DateTime));
    
            var campaignNameParameter = campaignName != null ?
                new ObjectParameter("CampaignName", campaignName) :
                new ObjectParameter("CampaignName", typeof(string));
    
            var agencyNameParameter = agencyName != null ?
                new ObjectParameter("AgencyName", agencyName) :
                new ObjectParameter("AgencyName", typeof(string));
    
            var periodFromParameter = periodFrom.HasValue ?
                new ObjectParameter("PeriodFrom", periodFrom) :
                new ObjectParameter("PeriodFrom", typeof(System.DateTime));
    
            var periodToParameter = periodTo.HasValue ?
                new ObjectParameter("PeriodTo", periodTo) :
                new ObjectParameter("PeriodTo", typeof(System.DateTime));
    
            var clientidParameter = clientid.HasValue ?
                new ObjectParameter("Clientid", clientid) :
                new ObjectParameter("Clientid", typeof(int));
    
            var brandidParameter = brandid.HasValue ?
                new ObjectParameter("Brandid", brandid) :
                new ObjectParameter("Brandid", typeof(int));
    
            var ponoParameter = pono != null ?
                new ObjectParameter("pono", pono) :
                new ObjectParameter("pono", typeof(string));
    
            var sacperParameter = sacper.HasValue ?
                new ObjectParameter("sacper", sacper) :
                new ObjectParameter("sacper", typeof(decimal));
    
            var aacperParameter = aacper.HasValue ?
                new ObjectParameter("aacper", aacper) :
                new ObjectParameter("aacper", typeof(decimal));
    
            var podateParameter = podate.HasValue ?
                new ObjectParameter("podate", podate) :
                new ObjectParameter("podate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CreateEstimateProc", estimatenoParameter, estimatedateParameter, campaignNameParameter, agencyNameParameter, periodFromParameter, periodToParameter, clientidParameter, brandidParameter, ponoParameter, sacperParameter, aacperParameter, podateParameter);
        }
    
        public virtual int sp_GetBrandMaster()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetBrandMaster");
        }
    
        public virtual int sp_GetClientMaster()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetClientMaster");
        }
    }
}
