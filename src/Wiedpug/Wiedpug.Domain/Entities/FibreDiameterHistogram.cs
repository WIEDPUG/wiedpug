namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogram
    {
        public FibreDiameterHistogramHeader? FibreDiameterHistogramHeader { get; set; } //31

        public List<FibreDiameterHistogramDetail>? FibreDiameterHistogramDetails { get; set; } //32A

    }
}
