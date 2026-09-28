// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
using System.Numerics;

// The namespace your code is in.
namespace GAME_10033_Game_Development_Foundations___2D_Game_Template__v1._6_1
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Pupil movement
        int pupilX = 0;
        int pupilY = 0;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw Simple Shapes");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear background to offwhite color
            Window.ClearBackground(240);
            //A head
            Draw.SetFillColor(252, 140, 3);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(10);
            Draw.Rectangle(70, 80, 260, 240);
            //B eye 
            Draw.SetFillColor(252, 140, 3);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(10);
            Draw.Circle(150, 145, 25);
            //C eye
            Draw.SetFillColor(252, 140, 3);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(10);
            Draw.Circle(250, 145, 25);
            //D nose
            Draw.SetFillColor(168, 52, 50);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(10);
            Draw.Ellipse(200, 230, 50, 25);
            //E mouth
            Draw.SetFillColor(252, 140, 3);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(10);

            // F Left side of mouth
            Draw.Line(200, 250, 200, 260);
            Draw.Line(200, 260, 185, 275);
            Draw.Line(185, 275, 170, 275);

            // G Right side of mouth
            Draw.Line(200, 260, 215, 275);
            Draw.Line(215, 275, 230, 275);
            // H ear left
            Draw.SetFillColor(252, 140, 3);
            Draw.Triangle(75, 90, 130, 20, 175, 90);
            // I ear right
            Draw.Triangle(225, 90, 280, 20, 325, 90);
            // J Pupils
            Draw.SetFillColor(0, 0, 0);

            Draw.Circle(150 + pupilX, 145 + pupilY, 10);
            Draw.Circle(250 + pupilX, 145 + pupilY, 10);
            {
                // Move pupils with arrow keys
                if (Input.IsKeyboardKeyDown(KeyboardKey.Left))
                    pupilX -= 2;
                if (Input.IsKeyboardKeyDown(KeyboardKey.Right))
                    pupilX += 2;
                if (Input.IsKeyboardKeyDown(KeyboardKey.Up))
                    pupilY -= 2;
                if (Input.IsKeyboardKeyDown(KeyboardKey.Down))
                    pupilY += 2;
                //keep pupils from moving too far
                pupilX = Math.Clamp(pupilX, -12, 12);
                pupilY = Math.Clamp(pupilY, -12, 12);
            
            }
        }
    
            }
        }
    



        
    
