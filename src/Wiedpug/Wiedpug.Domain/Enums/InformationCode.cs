using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    /// <summary>
    /// A code to indicate the information.
    /// 
    /// For AC, PC LI and GI transmissions, one record will be sent for each Wool Sale Header Lots received.
    /// 
    /// OK - aaaaaDATA RECEIVED OK FOR aann/nn dd/mm/yy ooooo LOTS nnnn
    /// 
    /// Where aann/nn = sale number/season
    ///     
    /// dd/mm/yy = sale date
    ///     
    /// ooooo = selling organisation
    ///     
    /// nnnnn = number of lots
    ///     
    /// Reason - You have sent data to the network and it has been received with no communication or transmission errors.
    /// 
    /// Action - None.
    /// 
    /// OR
    /// 
    /// For all other types of transmissions, one record will be sent for each transmission file received.
    /// 
    /// OK - ALL aaaaa DATA RECEIVED OK
    /// 
    /// Reason - You have sent data to the network and it has been received with no communication or transmission errors.
    /// 
    /// Action - None.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InformationCode
    {
        OK,
    }
}
