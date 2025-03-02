using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    internal abstract class Token<T>
    {
        private T value;

        public abstract T Value { get; set; }

        public abstract T evaluate();
    }
}
