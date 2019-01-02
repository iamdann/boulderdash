﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boulderdash.app.models
{
    abstract class Entity : Tile
    {
        public abstract char GetCharacter();

        public abstract ConsoleColor GetColor();

        public abstract void Destroy(Tile tile);

        public virtual Tile Move(Tile from, Tile to = null) { return null; }
    }
}
