using RenewableEnergyHomes.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenewableEnergyHomes.Domain.Repos
{
    public interface IPropertyRepo
    {
        Task<List<PropertySaleInfo>> PropertySalesByPostcodeAsync(string postcode);
    }
}
