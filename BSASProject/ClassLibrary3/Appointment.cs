//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int PhoneNo { get; set; }
        public string UserName { get; set; }
        public int ProductId { get; set; }
        public System.DateTime DateTime { get; set; }
        public int Price { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
