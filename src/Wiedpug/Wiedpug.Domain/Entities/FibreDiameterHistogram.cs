using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogram
    {
        public FibreDiameterHistogramHeader? FibreDiameterHistogramHeader { get; set; } //31

        public List<FibreDiameterHistogramDetailMeasurement>? FibreDiameterHistogramDetailMeasurements { get; set; }

    }
}
