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
        Color yellow    = new Color("#ebd9b0");
        Color lightBlue = new Color("#85b396");
        Color aqua      = new Color("#445e4e");
        Color green     = new Color("#abc123");
        Color darkGreen = new Color("#1f2b24");      
        Color color     = Random.Color();
        Color[] berryColors = new Color[2];
        Color[] cloudColors = new Color[2];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("2D Interactive Drawing");
            Window.SetSize(400, 400);
            berryColors[0] = new Color("#0226ab");    //RED
            berryColors[1] = new Color("#c20262");    //BLUE
            cloudColors[0] = new Color("#ffffee");    //WHITE
            cloudColors[1] = new Color("#666677");    //GREY
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(lightBlue);
            //draw sun
            Draw.FillColor = yellow;
            Draw.LineColor = Color.Clear;
            Draw.Circle(340, 60, 30);

            //reference bushes and berries
            DrawBushes(300, 0);
            DrawBerry(180, 0, berryColors);
            DrawCloud(80, 70, cloudColors);

            //change berry colour
            if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
            {
                color = berryColors[0];
            }

            else if (Input.IsKeyboardKeyPressed(KeyboardInput.B))
            {
                color = berryColors[1];
            }

            //change cloud colour
            if (Input.IsKeyboardKeyPressed(KeyboardInput.W))
            {
                color = cloudColors[0];
            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.G))
            {
                color = cloudColors[1];
            }
        }

        void DrawBerry(int x, int y, Color[] berryColors)
        {
            for (int i = 0; i < 21; i++)
            {
                Draw.FillColor = color;
                Draw.LineColor = Color.Clear;
                Draw.Circle(20 * i, 305, 2);
            }
        }

        void DrawCloud(int x, int y, Color[] cloudColors)
        {
            Draw.FillColor = color;
            Draw.LineColor = Color.Clear;
            Draw.Capsule(50, 80, 110, 80, 10);
            Draw.Circle(85, 70, 20);
            Draw.Circle(65, 75, 15);
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
    }

}
