using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogram
    {
        public FiberDiameterHistogramHeader? FiberDiameterHistogramHeader { get; set; }

        public List<FibreDiameterHistogramDetail>? FibreDiameterHistogramDetails { get; set; }

    }
}
