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
    
    public partial class LocalityGreatPlace
    {
        public decimal LocalityGreatPlaceId { get; set; }
        public Nullable<decimal> mLocalityId { get; set; }
        public string PlaceName { get; set; }
        public string PlaceDesc { get; set; }
        public string GreatPlaceUrl { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual GreatPlaceGallery GreatPlaceGallery { get; set; }
        public virtual LocalityDetail LocalityDetail { get; set; }
        public virtual mLocality mLocality { get; set; }
    }
}
