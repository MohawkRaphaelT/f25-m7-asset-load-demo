// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Texture2D face;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Asset Load Graphics");
            Window.SetSize(400, 400);
            // where are we?
            //string cwd = Directory.GetCurrentDirectory();
            //Console.WriteLine($"CWD: {cwd}");
            // load graphics
            face = Graphics.LoadTexture("../../../../assets/graphics/face.png");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            // show graphics
            Graphics.Rotation = Time.SecondsElapsed * 360 / 2.5f;
            Graphics.Draw(face, 200, 200);
        }
    }

}
