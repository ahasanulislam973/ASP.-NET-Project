//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory_Table
    {
        public int Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public string Edition { get; set; }
        public Nullable<int> Count { get; set; }
        public string Student_Id { get; set; }
    }
}
