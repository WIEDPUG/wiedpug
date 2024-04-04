using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum CombinationFlag
    {
        NormalCombination = 'N',
        ASX24Combination = 'S',
        ASX19554WCombination = '4',
        ASX21055WCombination = '5',
        ASX22656WCombination = '6',
        ASX19554WASX21055WASX22656WCombination = '7',
        ASX19554WASX21055WCombination = '8',
        ASX21055WASX22656WCombination = '9',
        ICAPWoolContractChinaType54P = 'A',
        ICAPWoolContractChinaType54 = 'B',
        ICAPWoolContractChinaType55 = 'C',
        ICAPWoolContractChinaType56 = 'D',
        ICAPWoolContractChinaType424 = 'E',
        ICAPWoolContractChinaTypeStandard = 'F'
    }
}
