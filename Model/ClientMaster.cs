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
    
    public partial class ClientMaster
    {
        public ClientMaster()
        {
            this.BrandMasters = new HashSet<BrandMaster>();
        }
    
        public int ClientID { get; set; }
        public string Client_Name { get; set; }
    
        public virtual ICollection<BrandMaster> BrandMasters { get; set; }
    }
}
