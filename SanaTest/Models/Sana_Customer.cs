//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SanaTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sana_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sana_Customer()
        {
            this.Sana_Order = new HashSet<Sana_Order>();
        }
    
        public long idCustomer { get; set; }
        public string fullname { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public System.DateTime creationDate { get; set; }
        public Nullable<System.DateTime> modificationDate { get; set; }
        public bool enable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sana_Order> Sana_Order { get; set; }
    }
}
