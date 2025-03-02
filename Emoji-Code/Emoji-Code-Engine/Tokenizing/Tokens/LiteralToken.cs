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
    internal abstract class LiteralToken<T> : Token<T>
    {
        protected LiteralToken(T value) : base(value)
        {
        }
    }
}
