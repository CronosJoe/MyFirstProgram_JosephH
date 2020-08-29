using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath; // mathematics utilities and operations (Vector2Add, etc.)
using System.Numerics; // mathematics types (Vector2, Vector3, etc.)
using System;
using Raylib_cs;


namespace raygamecsharp
{
    public class Player
    {
        public Vector2 position = new Vector2();
        public int width;
        public int height;
        public Color myColor = RED;
        public float collideMaxX;
        public float collideMinX;
        public float collideMaxY;
        public float collideMinY;

        public int RE;
        public int LE;
        public int Top;
        public int Bot;

        public void Update()
        {
            if (IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                position.X += 2.0f;
            }
            if (IsKeyDown(KeyboardKey.KEY_LEFT)) 
            {
                position.X -= 2.0f;
            }
            if (IsKeyDown(KeyboardKey.KEY_UP))
            {
                position.Y -= 2.0f;
            }
            if (IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                position.Y += 2.0f;
            }

           

        }
        public void FindEdges()
        {
            RE = (int)position.X + (width / 2);
            LE = (int)position.X - (width / 2);
            Top = (int)position.Y + (height / 2);
            Top = (int)position.Y - (height / 2);
        }
        public void Draw()
        {
            DrawRectangle((int)position.X, (int)position.Y, width,height, myColor);
        }
    }
}
