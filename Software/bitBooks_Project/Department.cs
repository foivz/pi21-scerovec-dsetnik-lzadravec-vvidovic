//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitBooks_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Publishings = new HashSet<Publishing>();
        }
    
        public int DepartmentID { get; set; }
        public int LibraryID { get; set; }
        public int PostalCode { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int DepartmentNum { get; set; }
    
        public virtual City City { get; set; }
        public virtual Library Library { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publishing> Publishings { get; set; }
    }
}