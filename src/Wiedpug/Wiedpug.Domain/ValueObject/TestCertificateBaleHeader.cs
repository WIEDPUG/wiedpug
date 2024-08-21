using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class TestCertificateBaleHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required string Brand { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(15)]
        public required string BaleDescription { get; set; }

        /// <summary>
        /// The code for the area in which the wool was grown.
        /// 
        /// For further information please go to this URL:
        /// 
        /// http://www.awex.com.au/market-information/wool-statistical-areas-wsa/
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(4)]
        public required string AreaOfOrigin { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string? LocationWithinStore { get; set; }
    }
}
