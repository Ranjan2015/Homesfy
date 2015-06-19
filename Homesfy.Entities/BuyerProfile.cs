//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homesfy.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyerProfile
    {
        public decimal BuyerId { get; set; }
        public Nullable<decimal> UserCredentialsId { get; set; }
        public Nullable<decimal> MartialStatusId { get; set; }
        public string Occupation { get; set; }
        public string ProfilePic { get; set; }
        public Nullable<decimal> Age { get; set; }
        public string CurrentLivingInformation { get; set; }
        public Nullable<decimal> CurrentRentRangeId { get; set; }
        public string PreviousLivingInformation { get; set; }
        public string CurrentCompanyName { get; set; }
        public Nullable<System.DateTime> WorkingSince { get; set; }
        public Nullable<decimal> SalaryRangeId { get; set; }
        public string EmployeeReferals { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual UserCredential UserCredential { get; set; }
    }
}
