﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LIVEEntities : DbContext
    {
        public LIVEEntities()
            : base("name=LIVEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sUser> sUsers { get; set; }
        public virtual DbSet<sMenu> sMenus { get; set; }
        public virtual DbSet<sPlant> sPlants { get; set; }
        public virtual DbSet<sRole> sRoles { get; set; }
        public virtual DbSet<sUserPage> sUserPages { get; set; }
        public virtual DbSet<FrdMachine> FrdMachines { get; set; }
        public virtual DbSet<FrdParameter> FrdParameters { get; set; }
        public virtual DbSet<sDocument> sDocuments { get; set; }
        public virtual DbSet<FrdSupplier> FrdSuppliers { get; set; }
        public virtual DbSet<FrdItem> FrdItems { get; set; }
        public virtual DbSet<FrdRequestDetail> FrdRequestDetails { get; set; }
        public virtual DbSet<FrdRequestMaster> FrdRequestMasters { get; set; }
        public virtual DbSet<sBenificiary> sBenificiaries { get; set; }
        public virtual DbSet<sDesignation> sDesignations { get; set; }
        public virtual DbSet<sUnit> sUnits { get; set; }
        public virtual DbSet<FrdReceiveDetail> FrdReceiveDetails { get; set; }
        public virtual DbSet<sPageName> sPageNames { get; set; }
        public virtual DbSet<sDept> sDepts { get; set; }
        public virtual DbSet<FrdApproval> FrdApprovals { get; set; }
        public virtual DbSet<FrdPurchaseInfo> FrdPurchaseInfoes { get; set; }
        public virtual DbSet<FrdPurchase> FrdPurchases { get; set; }
        public virtual DbSet<FrdReceiveMaster> FrdReceiveMasters { get; set; }
        public virtual DbSet<FrdStockMaster> FrdStockMasters { get; set; }
        public virtual DbSet<FrdItemIssue> FrdItemIssues { get; set; }
        public virtual DbSet<FrdIssueDetail> FrdIssueDetails { get; set; }
        public virtual DbSet<FrdItemTran> FrdItemTrans { get; set; }
        public virtual DbSet<FrdItemTranInfo> FrdItemTranInfoes { get; set; }
        public virtual DbSet<sParam> sParams { get; set; }
        public virtual DbSet<FrdItemInfo> FrdItemInfoes { get; set; }
    
        public virtual ObjectResult<spUserLoginToApplication_Result> spUserLoginToApplication(Nullable<int> userID, string userPass, string userPin)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var userPassParameter = userPass != null ?
                new ObjectParameter("UserPass", userPass) :
                new ObjectParameter("UserPass", typeof(string));
    
            var userPinParameter = userPin != null ?
                new ObjectParameter("UserPin", userPin) :
                new ObjectParameter("UserPin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUserLoginToApplication_Result>("spUserLoginToApplication", userIDParameter, userPassParameter, userPinParameter);
        }
    
        public virtual ObjectResult<spRequestData_Result> spRequestData(Nullable<int> inPlant, Nullable<int> inReqNo)
        {
            var inPlantParameter = inPlant.HasValue ?
                new ObjectParameter("inPlant", inPlant) :
                new ObjectParameter("inPlant", typeof(int));
    
            var inReqNoParameter = inReqNo.HasValue ?
                new ObjectParameter("inReqNo", inReqNo) :
                new ObjectParameter("inReqNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spRequestData_Result>("spRequestData", inPlantParameter, inReqNoParameter);
        }
    
        public virtual ObjectResult<spPurchaseData_Result> spPurchaseData(Nullable<int> inPlant, Nullable<int> inReqNo, Nullable<int> inType)
        {
            var inPlantParameter = inPlant.HasValue ?
                new ObjectParameter("inPlant", inPlant) :
                new ObjectParameter("inPlant", typeof(int));
    
            var inReqNoParameter = inReqNo.HasValue ?
                new ObjectParameter("inReqNo", inReqNo) :
                new ObjectParameter("inReqNo", typeof(int));
    
            var inTypeParameter = inType.HasValue ?
                new ObjectParameter("inType", inType) :
                new ObjectParameter("inType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPurchaseData_Result>("spPurchaseData", inPlantParameter, inReqNoParameter, inTypeParameter);
        }
    
        public virtual int spStockProduct(Nullable<int> inPlant, Nullable<int> inItenCode, Nullable<int> inTrans, Nullable<int> inQty, Nullable<decimal> inQtyd, Nullable<decimal> inUnit)
        {
            var inPlantParameter = inPlant.HasValue ?
                new ObjectParameter("inPlant", inPlant) :
                new ObjectParameter("inPlant", typeof(int));
    
            var inItenCodeParameter = inItenCode.HasValue ?
                new ObjectParameter("inItenCode", inItenCode) :
                new ObjectParameter("inItenCode", typeof(int));
    
            var inTransParameter = inTrans.HasValue ?
                new ObjectParameter("inTrans", inTrans) :
                new ObjectParameter("inTrans", typeof(int));
    
            var inQtyParameter = inQty.HasValue ?
                new ObjectParameter("inQty", inQty) :
                new ObjectParameter("inQty", typeof(int));
    
            var inQtydParameter = inQtyd.HasValue ?
                new ObjectParameter("inQtyd", inQtyd) :
                new ObjectParameter("inQtyd", typeof(decimal));
    
            var inUnitParameter = inUnit.HasValue ?
                new ObjectParameter("inUnit", inUnit) :
                new ObjectParameter("inUnit", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spStockProduct", inPlantParameter, inItenCodeParameter, inTransParameter, inQtyParameter, inQtydParameter, inUnitParameter);
        }
    
        public virtual ObjectResult<Work_order_Result> Work_order(Nullable<int> reqId)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Work_order_Result>("Work_order", reqIdParameter);
        }
    
        public virtual ObjectResult<machineWiseAmount_Result> machineWiseAmount(Nullable<int> wId)
        {
            var wIdParameter = wId.HasValue ?
                new ObjectParameter("wId", wId) :
                new ObjectParameter("wId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<machineWiseAmount_Result>("machineWiseAmount", wIdParameter);
        }
    
        public virtual ObjectResult<IssueReturnQty_Result> IssueReturnQty(Nullable<int> wId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var wIdParameter = wId.HasValue ?
                new ObjectParameter("wId", wId) :
                new ObjectParameter("wId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IssueReturnQty_Result>("IssueReturnQty", wIdParameter, startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<qualityAssurance_Result> qualityAssurance(Nullable<int> pid, Nullable<int> recrcid)
        {
            var pidParameter = pid.HasValue ?
                new ObjectParameter("pid", pid) :
                new ObjectParameter("pid", typeof(int));
    
            var recrcidParameter = recrcid.HasValue ?
                new ObjectParameter("recrcid", recrcid) :
                new ObjectParameter("recrcid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<qualityAssurance_Result>("qualityAssurance", pidParameter, recrcidParameter);
        }
    
        public virtual ObjectResult<requisitionSlip_Result> requisitionSlip(Nullable<int> reqId, Nullable<int> plantId)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            var plantIdParameter = plantId.HasValue ?
                new ObjectParameter("plantId", plantId) :
                new ObjectParameter("plantId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<requisitionSlip_Result>("requisitionSlip", reqIdParameter, plantIdParameter);
        }
    }
}