﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace molyjam
{
    class Entity
    {
        Vector2 origin;
        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        Texture2D texture;
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public Entity(Vector2 _origin, Texture2D _texture)
        {
            origin = _origin;
            texture = _texture;
        }

        public void moveEntity(Vector2 vector)
        {
            origin.X += vector.X;
            origin.Y -= vector.Y;
        }
    }
}