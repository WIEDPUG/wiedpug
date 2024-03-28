using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum DeliveryBasis
    {
        [Description("Delivery Nominated Destination")]
        D,
        [Description("Loaded on Transport")]
        L
    }
}
