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

        /// <summary>
        /// The broker that is responsible for releasing the wool out of the store
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation ReleasingOrganisation { get; set; }

        /// <summary>
        /// The code for the organisation which is to apply marks to the bales.
        /// </summary>
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
        /// A boolean value to indicate whether to apply renumbers on bales. 
        ///
        /// true: apply renumbers.
        ///
        /// false: not apply renumbers.
        /// </summary>
        [Required]

        public required bool AreRenumbersApplied { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to apply Gross Weights on bales.
        ///
        /// true: apply.
        ///
        /// false: not apply.
        /// </summary>
        [Required]

        public required bool AreGrossWeightsApplied { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to apply Net Weights on bales.
        ///
        /// true: apply
        ///
        /// false: not apply
        /// </summary>
        [Required]

        public required bool AreNetWeightsApplied { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? InterimHandlingDestinationCode { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? InterimHandlerDescriptionLine1 { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? InterimHandlerDescriptionLine2 { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? FinalDestinationCode { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? FinalDestinationDescriptionLine1 { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? FinalDestinationDescriptionLine2 { get; set; }



    }

}
