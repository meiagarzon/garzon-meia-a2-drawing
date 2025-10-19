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
        Color yellow = new Color("#ebd9b0");
        Color lightBlue = new Color("#85b396");
        Color aqua = new Color("#445e4e");
        Color green = new Color("#abc123");
        Color darkGreen = new Color("#1f2b24");
        Color color = Random.Color();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("2D Interactive Drawing");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(lightBlue);
            DrawBushes(300, 33);

            //change berry colour
            if (Input.IsMouseButtonPressed(MouseInput.Left) ||
                Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                color = Random.Color();
            }

            DrawBerry(180, 300);

            //draw sun
            Draw.FillColor = yellow;
            Draw.LineColor = Color.Clear;
            Draw.Circle(340, 60, 30);
        }

        void DrawBushes(int x, int y)
        {
            for (int i = 0; i < 12; i++)
            {
                Draw.FillColor = darkGreen;
                Draw.Circle(40 * i, 300, 33);
            }

            for (int i = 0; i < 6; i++)
            {
                Draw.FillColor = green;
                Draw.Circle(80 * i, 350, 66);
            }

            //draw grass
            Draw.FillColor = aqua;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(0, 310, 400, 200);
        }

        void DrawBerry(int x, int y)
        {
            for (int i = 0; i < 21; i++)
            {
                Draw.FillColor = color;
                Draw.LineColor= Color.Clear;
                Draw.Circle(20 * i, 305, 2);
            }
        }
    }

}
