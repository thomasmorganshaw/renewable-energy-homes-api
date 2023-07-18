using System;
using System.Collections.Generic;

namespace RenewableEnergyHomes.Domain.Entities
{
    public class PropertySaleInfo
    {
        public PropertySaleInfo()
        {
            PropertyFeatures = new List<PropertyFeatureInfo>();
        }

        public int Id { get; set; }
        public string Postcode { get; set; }
        public string HouseNumber { get; set; }
        public string HouseName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string EpcRating { get; set; }
        public DateTime? DateOfSale { get; set; }
        public long? SaleAmount { get; set; }
        public List<PropertyFeatureInfo> PropertyFeatures { get; set; }
    }
}
