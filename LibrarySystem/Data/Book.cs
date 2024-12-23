//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookIssues = new HashSet<BookIssue>();
        }
    
        public int BookId { get; set; }
        public string ISBNCode { get; set; }
        public string BookTitle { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public Nullable<System.DateTime> PublicationYear { get; set; }
        public Nullable<byte> BookEdition { get; set; }
        public int CopiesTotal { get; set; }
        public int CopiesAvailable { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssue> BookIssues { get; set; }
    }
}
