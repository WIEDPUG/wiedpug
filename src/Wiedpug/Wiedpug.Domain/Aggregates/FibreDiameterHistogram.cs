using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates
{
    public class FibreDiameterHistogram
    {
        public FibreDiameterHistogramHeader? FibreDiameterHistogramHeader { get; set; } //31
                        
        public List<FibreDiameterHistogramDetail>? FibreDiameterHistogramDetails { get; set; } //32A

    }
}
