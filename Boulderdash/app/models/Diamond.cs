﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boulderdash.app.models
{
    class Diamond : Moveable
    {
        public override char GetCharacter()
        {
            return '♦';
        }

        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Cyan;
        }

        //Destroy Diamond
        public override void Destroy(Tile destroyable)
        {
            Tile.Level.Score += 10;
            base.Destroy(destroyable);
        }
    }
}
