//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BooksTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BooksTable()
        {
            this.BookFineTables = new HashSet<BookFineTable>();
            this.BookIssuesTables = new HashSet<BookIssuesTable>();
            this.BookReturnTables = new HashSet<BookReturnTable>();
            this.PurchaseDetailTables = new HashSet<PurchaseDetailTable>();
            this.PurTemDetailsTables = new HashSet<PurTemDetailsTable>();
        }
    
        public int BookID { get; set; }
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public int BookTypeID { get; set; }
        public string BookTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public double Edition { get; set; }
        public int TotalCopies { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime RegDate { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookFineTable> BookFineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssuesTable> BookIssuesTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        public virtual BookTypeTable BookTypeTable { get; set; }
        public virtual DepartmentsTable DepartmentsTable { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetailTable> PurchaseDetailTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurTemDetailsTable> PurTemDetailsTables { get; set; }
    }
}
