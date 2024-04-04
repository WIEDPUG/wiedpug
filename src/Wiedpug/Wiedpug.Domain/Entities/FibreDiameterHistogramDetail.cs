using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogramDetail
    {        
        [Required]
        public required FibreDiameterHistogramDetailMeasurement FibreMeasurement1 { get; set; } // FIELD NUMBER 3 - Fibre Diameter-(1) - Start: 4, Size: 2, Data Type: N, Justification: R, Requirement Designator: M
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement2 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement3 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement4 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement5 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement6 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement7 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement8 { get; set; }
        public FibreDiameterHistogramDetailMeasurement? FibreMeasurement9 { get; set; }
    }
}
