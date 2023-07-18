using Microsoft.AspNetCore.Mvc;
using RenewableEnergyHomes.Api.Application.Commands;
using RenewableEnergyHomes.Api.Infrastructure;

namespace RenewableEnergyHomes.Api.Controllers
{
    [ApiController]
    [Route("property")]
    public class PropertySearchController : ControllerBase
    {
        private readonly IPropertySearchHandler _propertySearchHandler;

        public PropertySearchController(IPropertySearchHandler propertySearchHandler)
        {
            _propertySearchHandler = propertySearchHandler;
        }

        [HttpGet("search/{postcode}")]
        public async Task<IActionResult> PropertySearch(string postcode)
        {
            return Ok(await _propertySearchHandler.SearchAsync(new PropertySearchCommand(postcode)));
        }
    }
}