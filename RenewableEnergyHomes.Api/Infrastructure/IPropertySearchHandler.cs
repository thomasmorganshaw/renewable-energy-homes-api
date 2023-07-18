using RenewableEnergyHomes.Api.Application.Commands;
using RenewableEnergyHomes.Domain.Entities;

namespace RenewableEnergyHomes.Api.Infrastructure
{
    public interface IPropertySearchHandler
    {
        Task<PropertySearchResult> SearchAsync(PropertySearchCommand request);
    }
}
