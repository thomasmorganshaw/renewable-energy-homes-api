using RenewableEnergyHomes.Api.Application.Commands;
using RenewableEnergyHomes.Domain.Entities;
using Serilog;
using System.Text.RegularExpressions;

namespace RenewableEnergyHomes.Api.Application.Extensions
{
    public static class ValidationExtensions
    {
        public static bool IsValid(this PropertySearchCommand request, out List<ValidationMessage> messages)
        {
            var postcodeToTest = request.Postcode.Replace(" ", "");

            var match = Regex.Match(
                postcodeToTest,
                "(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY]))))[0-9][A-Z-[CIKMOV]]{2})",
                RegexOptions.IgnoreCase);

            messages = match.Success
                ? new List<ValidationMessage>()
                : new List<ValidationMessage>
                {
                    new ValidationMessage
                    {
                        Field = "Postcode",
                        Message = "Value was not in the expected UK postcode format."
                    }
                };

            if (!match.Success) Log.Warning("Validation failed {@messages}", messages);

            return match.Success;
        }
    }
}
