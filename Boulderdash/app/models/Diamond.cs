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

        //Move Diamond
        public override Tile Move(Tile from, Tile to)
        {
            if (to.IsAir() && from.Bottom.IsAir())
                Move(from, to.Bottom);

            if (to.IsAir())
            {
                to.Entity = from.Entity;
                from.Entity = new Air();
                return to;
            }

            return from;
        }

        //Destroy Diamond
        public override void Destroy(Tile tile)
        {
            tile.Entity = new Air();
        }
    }
}
