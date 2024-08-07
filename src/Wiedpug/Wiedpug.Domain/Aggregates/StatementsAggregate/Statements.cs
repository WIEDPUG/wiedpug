﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.StatementsAggregate
{
    public class Statements
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// 
        /// Should only be required for document upload/create/update.
        /// 
        /// Should be excluded when returning document to members.
        /// </summary>
        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<Statement> StatementCollection { get; set; }
    }
}
