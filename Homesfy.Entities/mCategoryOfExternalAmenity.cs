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
    
    public partial class mCategoryOfExternalAmenity
    {
        public mCategoryOfExternalAmenity()
        {
            this.BuilderProjExternalAmenities = new HashSet<BuilderProjExternalAmenity>();
        }
    
        public decimal mCategoryOfExternalAmenities { get; set; }
        public Nullable<decimal> mNeighbourHoodId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
    
        public virtual ICollection<BuilderProjExternalAmenity> BuilderProjExternalAmenities { get; set; }
        public virtual mNeighbourHoodTag mNeighbourHoodTag { get; set; }
    }
}
