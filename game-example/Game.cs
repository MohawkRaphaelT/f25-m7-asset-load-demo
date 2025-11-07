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
        // Place your variables here:
        Sound sfx1;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Asset Load Audio");
            Window.SetSize(400, 400);
            // load audio
            sfx1 = Audio.LoadSound("../../../../assets/audio/sound.wav");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            // play audio
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                Audio.Play(sfx1);
            }
        }
    }

}
