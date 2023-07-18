using System.ComponentModel.DataAnnotations.Schema;

namespace RenewableEnergyHomes.Infrastructure.Entities
{
    public class PropertySale
    {
        public int Id { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
        public int PropertyId { get; set; }

        public DateTime? DateOfSale { get; set; }
        public long? SaleAmount { get; set; }
    }
}
