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
    
    public partial class LocalityDetailsCommute
    {
        public decimal LocalityDetailsCommuteId { get; set; }
        public Nullable<decimal> mLocalityId { get; set; }
        public string DistanceIcon { get; set; }
        public string CommuteName { get; set; }
        public Nullable<System.TimeSpan> CommuteDistanceInTimeByTaxi { get; set; }
        public Nullable<System.TimeSpan> CommuteDistanceInTimeByTrain { get; set; }
    
        public virtual LocalityDetail LocalityDetail { get; set; }
        public virtual mLocality mLocality { get; set; }
    }
}
