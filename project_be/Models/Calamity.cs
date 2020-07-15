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
    
    public partial class Calamity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calamity()
        {
            this.CalamityActors = new HashSet<CalamityActor>();
            this.CalamityTools = new HashSet<CalamityTool>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilmingLocation { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public Nullable<int> NumberOfFilming { get; set; }
        public bool DelFlg { get; set; }
        public Nullable<int> InsId { get; set; }
        public System.DateTime InsTime { get; set; }
        public Nullable<int> UpdId { get; set; }
        public Nullable<System.DateTime> UpdTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalamityActor> CalamityActors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalamityTool> CalamityTools { get; set; }
    }
}
