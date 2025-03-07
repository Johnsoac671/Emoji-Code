﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens
{
    /// <summary>
    /// A token representing a keyword identifier in the code (e.x. print)
    /// </summary>
    public abstract class KeywordToken : Token
    {
        protected KeywordToken(string value) : base(value)
        {
        }
    }
}
