//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpprepningExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            this.Titles = new HashSet<Title>();
        }
    
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string CountryOfResidence { get; set; }
        public string SpouseName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Title> Titles { get; set; }
    }
}
