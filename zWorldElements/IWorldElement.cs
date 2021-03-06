﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace zWorldElements
{
    public interface IWorldElement
    {
        Rectangle rectangle { get; }
        string tag { get; }
        void Draw(SpriteBatch spriteBatch);
    }
}
