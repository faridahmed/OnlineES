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
    
    public partial class sUser
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserPin { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string MobileNo { get; set; }
        public string UserStatus { get; set; }
        public Nullable<int> PlantNo { get; set; }
        public string Email { get; set; }
        public string LoginType { get; set; }
        public Nullable<int> ActiveSession { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}