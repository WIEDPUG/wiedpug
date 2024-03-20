using System.Runtime.Serialization;

namespace Wiedpug.Domain.Entities
{
    public class SaleIdentity
    {
        public string SellingCentreType { get; set; }

        public int? SaleNumber { get; set; }
    }
}