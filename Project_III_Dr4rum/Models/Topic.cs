//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_III_Dr4rum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topic()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public string Topic_Title { get; set; }
        public int Acc_ID { get; set; }
        public string Category_Name { get; set; }
        public bool setV { get; set; }
        public string Topic_Info { get; set; }
        public int Report { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}