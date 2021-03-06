﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using zTools;

namespace zWorldElements
{
    public class WorldBlock : IWorldElement
    {
        Texture2D texture2D;
        Point centerPoint;
        public string tag { get; }
        public Rectangle rectangle { get => new Rectangle().Create(centerPoint, texture2D); }

        public WorldBlock(Point centerPoint, Texture2D texture2D, string tag)
        {
            this.texture2D = texture2D;
            this.centerPoint = centerPoint;
            this.tag = tag;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture2D, rectangle, Color.White);
        }
    }
}
