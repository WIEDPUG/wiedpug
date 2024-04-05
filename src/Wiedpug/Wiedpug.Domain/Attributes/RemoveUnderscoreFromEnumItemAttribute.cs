using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Attributes
{
    /// <summary>
    /// This is a flag for enum when there is any item that starts with an underscore.
    /// Use this flag when the enum contain items that starts with mix of number and letter.
    /// C# does not allow an enum item to start with a number. Therefore, an underscore prefix gets added in place.
    /// This flag is used in `ManipulateEnumForOpenApiSpec` class to decide whether to recreate the enum without underscore prefix.
    /// </summary>
    public class RemoveUnderscoreFromEnumItemAttribute : Attribute
    {
    }
}
