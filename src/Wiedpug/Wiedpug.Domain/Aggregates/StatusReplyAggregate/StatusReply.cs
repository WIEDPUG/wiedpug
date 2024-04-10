using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.StatusReplyAggregate
{
    public class StatusReply
    {
        public required TransmissionHeader TransmissionHeader { get; set; }
        public List<TransmissionResponse>? Responses { get; set; }

    }
}
