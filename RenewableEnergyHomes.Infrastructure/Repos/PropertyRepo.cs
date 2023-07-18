using RenewableEnergyHomes.Domain.Entities;
using RenewableEnergyHomes.Domain.Repos;
using RenewableEnergyHomes.Infrastructure.DbContexts;

namespace RenewableEnergyHomes.Infrastructure.Repos
{
    public class PropertyRepo : IPropertyRepo
    {
        private readonly PropertyDataContext _propertyDataContext;

        public PropertyRepo(PropertyDataContext propertyDataContext)
        {
            _propertyDataContext = propertyDataContext;
        }

        public async Task<List<PropertySaleInfo>> PropertySalesByPostcodeAsync(string postcode)
        {
            var properties = _propertyDataContext.Properties
                .Where(x => x.Postcode == postcode)
                .OrderBy(x => x.Id)
                .Select(x =>
                    new PropertySaleInfo
                    {
                        Id = x.Id,
                        Postcode = x.Postcode,
                        HouseNumber = x.HouseNumber,
                        HouseName = x.HouseName,
                        AddressLine1 = x.AddressLine1,
                        AddressLine2 = x.AddressLine2,
                        AddressLine3 = x.AddressLine3,
                        Town = x.Town,
                        County = x.County,
                        EpcRating = x.EpcRating,
                        DateOfSale = x.PropertySales.OrderByDescending(ps => ps.DateOfSale).First().DateOfSale,
                        SaleAmount = x.PropertySales.OrderByDescending(ps => ps.DateOfSale).First().SaleAmount,
                    })
                .ToList();

            return properties;
        }
    }
}
