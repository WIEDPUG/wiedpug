
namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogram
    {
        public FibreDiameterHistogramHeader? FiberDiameterHistogramHeader { get; set; }

        public List<FibreDiameterHistogramDetail>? FibreDiameterHistogramDetails { get; set; }

    }
}
