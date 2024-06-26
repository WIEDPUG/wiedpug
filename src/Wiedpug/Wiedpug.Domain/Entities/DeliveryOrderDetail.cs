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
        [StringLength(1)]
        public required DeliveryOrderType DeliveryOrderType { get; set; }

        [Required]
        [StringLength(10)]
        public required string DeliveryOrderNumber { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation ReleasingOrganisation { get; set; }

        [StringLength(8)]
        public Organisation? MarkingOrganisation { get; set; }

        [StringLength(10)]
        public string? PreviousDeliveryOrderNumber { get; set; }

        [Required]
        [StringLength(10)]
        public required Organisation Carrier { get; set; }

        public CountermarkColour? CountermarkColour { get; set; }

        public CountermarkMarking? CountermarkMarking { get; set; }

        public CountermarkSize? CountermarkSize { get; set; }

        public CountermarkHeadmarkFlag? CountermarkHeadmarkFlag { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        public required bool ApplyRenumbers { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        public required bool ApplyGrossWeights { get; set; }

        /// <summary>
        /// Boolean value to indicate wethear to apply renumbers on bales
        /// True for apply renumbers, False for not apply renumbers
        /// </summary>
        [Required]
        public required bool ApplyNetWeights { get; set; }

        public Organisation? InterimHandlingDestinationCode { get; set; }

        [StringLength(80)]
        public string? InterimHandlerDescriptionLine { get; set; }

        public Organisation? FinalDestinationCode { get; set; }

        [StringLength(80)]
        public string? FinalDestinationDescriptionLine { get; set; }



    }

}
