//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public int RoleConnectionID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Role1 { get; set; }
    
        public virtual User User { get; set; }
    }
}
