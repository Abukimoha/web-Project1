//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMangement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactiontbl
    {
        public int TransactionId { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookISBN { get; set; }
        public string TranStatus { get; set; }
        public string TransactionDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
    
        public virtual Booktbl Booktbl { get; set; }
        public virtual Usertbl Usertbl { get; set; }
    }
}