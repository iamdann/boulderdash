using System;
using System.Linq;

namespace Boulderdash.app.models
{
    public class Exit : Air
    {
        public override char GetCharacter()
        {
            return 'x';
        }
        
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }
    }
}