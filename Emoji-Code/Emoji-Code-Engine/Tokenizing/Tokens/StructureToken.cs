using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    /// <summary>
    /// A token representing a structural element of code (e.x. an End of Line symbol)
    /// </summary>
    public class StructureToken : Token
    {
        public StructureToken(string value): base(value) {}
    }
}
