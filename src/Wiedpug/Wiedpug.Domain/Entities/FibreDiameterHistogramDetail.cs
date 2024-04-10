using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogramDetail
    {        
        [Required]
        public required List<FibreDiameterHistogramDetailMeasurement> FibreMeasurements { get; set; }
    }
}
