using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    /// <summary>
    /// A token representing an operator
    /// </summary>
    public class OperatorToken : Token
    {
        public OperatorToken(string value) : base(value) { }
    }
}
