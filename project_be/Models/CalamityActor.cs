//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_be.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CalamityActor
    {
        public int CalamityId { get; set; }
        public int ActorId { get; set; }
        public string Role { get; set; }
        public string RoleDescription { get; set; }
        public bool DelFlg { get; set; }
        public int InsId { get; set; }
        public System.DateTime InsTime { get; set; }
        public Nullable<int> UpdId { get; set; }
        public Nullable<System.DateTime> UpdTime { get; set; }
        public string CalamityDescription { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Calamity Calamity { get; set; }
    }
}
