using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    /// <summary>
    /// Class representing a single token from the input codestring
    /// </summary>
    public abstract class Token
    {

        private readonly string value;

        public Token(string value)
        {
            this.value = value;
        }

        public string Value
        {
            get
            {
                return value;
            }
        }

    }
}
