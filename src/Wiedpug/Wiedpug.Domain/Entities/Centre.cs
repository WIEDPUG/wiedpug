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
    public class Centre
    {
        public  CentreAustralia? CentreAustralia { get; set; }

        public CentreNewZealand? CentreNewZealand { get; set; }

        public CentreOverseas? CentreOverseas { get; set; }

    }
}
