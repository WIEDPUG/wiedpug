using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class DeliveryOrderDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DeliveryOrderType DeliveryOrderType { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DeliveryOrderNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation ReleasingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? MarkingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string? PreviousDeliveryOrderNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public required Organisation Carrier { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CountermarkColour? CountermarkColour { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CountermarkMarking? CountermarkMarking { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CountermarkSize? CountermarkSize { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CountermarkHeadmarkFlag? CountermarkHeadmarkFlag { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool ApplyRenumbers { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool ApplyGrossWeights { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool ApplyNetWeights { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? InterimHandlingDestinationCode { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? InterimHandlerDescriptionLine { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? FinalDestinationCode { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? FinalDestinationDescriptionLine { get; set; }



    }

}
