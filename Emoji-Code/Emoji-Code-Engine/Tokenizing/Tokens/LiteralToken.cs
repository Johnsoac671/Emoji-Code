using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    /// <summary>
    /// A token representing a literal value
    /// </summary>
    public abstract class LiteralToken : Token
    {
        protected LiteralToken(string value) : base(value)
        {
        }
    }
}
