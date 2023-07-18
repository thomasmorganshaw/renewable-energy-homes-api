using System.Collections.Generic;

namespace RenewableEnergyHomes.Domain.Entities
{
    public class PropertySearchResult
    {
        public PropertySearchResult()
        {
            PostcodeLocation = new PostcodeLocation();
            PropertySales = new List<PropertySaleInfo>();
            ValidationFailures = new List<ValidationMessage>();
        }

        public PostcodeLocation PostcodeLocation { get; set; }

        public List<PropertySaleInfo> PropertySales { get; set; }

        public List<ValidationMessage> ValidationFailures { get; set; }
    }
}
