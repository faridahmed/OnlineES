//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FrdItem
    {
        public int Id { get; set; }
        public int ItemNo { get; set; }
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<int> ItemType { get; set; }
        public Nullable<int> ItemTypeCode { get; set; }
        public Nullable<int> ItemUnitCode { get; set; }
        public int PlantCode { get; set; }
        public Nullable<int> ItemMachineCode { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string TaxFlag { get; set; }
        public int ConvertValue { get; set; }
        public string UseFor { get; set; }
        public string Show { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}