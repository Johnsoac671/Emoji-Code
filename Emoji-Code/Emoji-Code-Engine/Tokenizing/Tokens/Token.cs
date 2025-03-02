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
    /// <typeparam name="T">The type of the value being input. Only really relevant for Literal values</typeparam>
    internal abstract class Token<T>
    {

        private readonly T value;

        public Token(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get
            {
                return value;
            }
        }

    }
}
