//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class BrandMaster
    {
        public BrandMaster()
        {
            this.CaptionMasters = new HashSet<CaptionMaster>();
        }
    
        public int BrandID { get; set; }
        public string Brand_Name { get; set; }
        public int ClientID { get; set; }
    
        public virtual ClientMaster ClientMaster { get; set; }
        public virtual ICollection<CaptionMaster> CaptionMasters { get; set; }
    }
}
