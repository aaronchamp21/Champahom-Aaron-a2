// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
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
            //A
            Draw.SetFillColor(0, 0, 0);
            Draw.SetLineColor(255, 255, 255);
            Draw.SetLineSize(10);
            Draw.Circle(200, 200, 100);
            //B
            Draw.SetFillColor(255, 255, 255);
            Draw.SetLineColor(0, 0, 0);
            Draw.SetLineSize(0);
            Draw.Circle(150, 150, 15);


        }
    }

}
