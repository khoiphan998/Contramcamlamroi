//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contramcamlamroi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderPro
    {
        public OrderPro()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> DateOrder { get; set; }
        public Nullable<int> IDCus { get; set; }
        public string AddressDeliverry { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
