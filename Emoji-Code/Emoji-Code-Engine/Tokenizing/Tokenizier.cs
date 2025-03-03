using System.Text;
using Emoji_Code_Engine.Tokenizing.Tokens;

namespace Emoji_Code_Engine.Tokenizing
{
    /// <summary>
    /// Converts source code into a list of Tokens (for parsing later)
    /// </summary>
    public class Tokenizier
    {
        private StreamReader sourceCode;

        public Tokenizier(StreamReader sourceCode)
        {
            this.sourceCode = sourceCode;
        }

        /// <summary>
        /// Processes the next "word" in the source code, and returns the approprite Token object
        /// </summary>
        /// <returns>Token object representing next token in source code</returns>
        public Token GetNextToken()
        {
            StringBuilder stringBuilder = new StringBuilder();
            char nextChar;

            while (true)
            {
                nextChar = (char)sourceCode.Read();

                if ((nextChar == ' ' || nextChar == '\n' || nextChar == '\t') || sourceCode.EndOfStream)
                {
                    break;
                }   
                
                stringBuilder.Append(nextChar);
            }

            return ConvertStringToToken(stringBuilder.ToString());
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
