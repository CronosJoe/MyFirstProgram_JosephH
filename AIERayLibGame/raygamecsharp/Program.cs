/*******************************************************************************************
*
*   raylib [core] example - Basic window
*
*   Welcome to raylib!
*
*   To test examples, just press F6 and execute raylib_compile_execute script
*   Note that compiled executable is placed in the same folder as .c file
*
*   You can find all basic examples on C:\raylib\raylib\examples folder or
*
*   Enjoy using raylib. :)
*
*   This example has been created using raylib-cs 3.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   This example was lightly modified to provide additional 'using' directives to make
*   common math types and utilities readily available, though they are not using in this sample.
*
*   Copyright (c) 2019-2020 Academy of Interactive Entertainment (@aie_usa)
*   Copyright (c) 2013-2016 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath; // mathematics utilities and operations (Vector2Add, etc.)
using System.Numerics;          // mathematics types (Vector2, Vector3, etc.)
using Raylib_cs;
using raygamecsharp;
using System;

namespace Examples
{
    public class core_basic_window
    {

        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;
            
            InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");
            Player player = new Player();
            Player pickTest3 = new Player();
            int score = 0;
         
            player.height = 40;
            player.width = 40;
            player.position.X = screenWidth / 2;
            player.position.Y = screenHeight / 2;

            pickTest3.height = 30;
            pickTest3.width = 30;
            pickTest3.position.X = GetRandomValue(0, screenWidth);
            pickTest3.position.Y = GetRandomValue(0, screenHeight);
            pickTest3.FindEdges();
            
            
            SetTargetFPS(60); 
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                player.Update();
                player.FindEdges();
                pickTest3.FindEdges();
                bool collision = CheckCollisionBoxes(player,pickTest3);
               if(collision)
               {
                    pickTest3.myColor = SKYBLUE;
                    pickTest3.position.X = GetRandomValue(0, screenWidth);
                    pickTest3.position.Y = GetRandomValue(0, screenHeight);
                    score++;
                }
                else
                {
                    pickTest3.myColor = RED;
                }

                if (player.position.X > screenWidth)
                {
                    player.position.X = 10;
                }
                if(player.position.X < 0)
                {
                    player.position.X = screenWidth - 10;
                }
                if (player.position.Y > screenHeight)
                {
                    player.position.Y = 10;
                }
                if (player.position.Y < 0)
                {
                    player.position.Y = screenHeight - 10;
                }


                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                BeginDrawing();

                ClearBackground(GRAY);
                DrawText(("SCORE: " + score), 280, 130, 40, MAROON);
                player.Draw();
                pickTest3.Draw();
                    

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }

        private static bool CheckCollisionBoxes(Player player, Player pickTest3)
        {
            bool collide = false;
            if ((player.RE >= pickTest3.LE && player.Top >= pickTest3.Bot && player.Bot <=pickTest3.Top && player.LE <=pickTest3.RE)|| player.RE <= pickTest3.LE && player.Top <= pickTest3.Bot && player.Bot >= pickTest3.Top && player.LE >= pickTest3.RE)
            {
                collide = true;
            }
            return collide;
        }
    }
}