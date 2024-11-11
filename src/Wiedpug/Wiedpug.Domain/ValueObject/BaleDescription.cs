using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    /// <summary>
    /// This field is to be always transmitted in upper case.
    /// </summary>
    public class BaleDescription
    {
        [MinLength(1)]
        [MaxLength(15)]
        public string? BaleDescriptionContent { get; set; }
    }
}
