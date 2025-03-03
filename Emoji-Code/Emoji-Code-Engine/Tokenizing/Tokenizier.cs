﻿using Emoji_Code_Engine.Tokenizing.Tokens;

namespace Emoji_Code_Engine.Tokenizing
{
    /// <summary>
    /// Converts source code into a list of Tokens (for parsing later)
    /// </summary>
    public class Tokenizier
    {
        private TextReader sourceCode;

        public Tokenizier(TextReader sourceCode)
        {
            this.sourceCode = sourceCode;
        }

        /// <summary>
        /// Processes the next token in the source code, and returns the approprite Token object
        /// </summary>
        /// <returns>Token object representing next token in source code</returns>
        public Token GetNextToken()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts the given word into a Token object
        /// </summary>
        /// <param name="input">the string to be turned into a token</param>
        /// <returns>Token object containing the given string</returns>
        private Token ConvertStringToToken(string input)
        {
            throw new NotImplementedException();
        }

    }
}
