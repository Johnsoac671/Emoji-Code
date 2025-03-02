using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Code_Engine.Tokenizing.Tokens.Literals
{
    internal class IntToken : LiteralToken<int>
    {
        private int value;

        public override int Value 
        { 
            get 
            { 
                return value; 
            } 

            set
            {
                this.value = value;
            }
        }

        public override int evaluate()
        {
            return this.value;
        }
    }
}
