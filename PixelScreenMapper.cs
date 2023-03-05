namespace Blocks
{
    public class PixelScreenMapper : VirtualScreen
    {
        /// <summary>
        /// Constructor for default screen - top left is at 0,0
        /// </summary>
        /// <param name="width">The width of the useable screen in printable characters</param>
        /// <param name="height">The height of the useable screen in printable characters</param>
        public PixelScreenMapper(int width, int height) : base(width*2, height*2)
        {
            Console.Clear();
        }

        /// <summary>
        /// Prints the appropriate Pixelled character onto the screen
        /// </summary>
        /// <param name="x">The distance from the left hand edge in characters</param>
        /// <param name="y">The distance from the top edge in characters</param>
        public void DisplayCharacterAt (int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(MapPixelsToConsoleCharacter(x ,y));
        }

        /// <summary>
        /// Sets the VirtualScreen from a Screen character
        /// </summary>
        /// <param name="x">The character x position</param>
        /// <param name="y">The character y position</param>
        /// <param name="shape">The block character to set at that position</param>
        public void SetCharacterAt (int x, int y, ConsoleShapeToDecimal shape)
        {
            int testTotal = (int)shape;

            // test for the bottom right corner of the 2x2 character
            if (testTotal >= 8)
            {
                Poke(x*2 + 1, y*2 + 1, Pixel.Set);
                testTotal = testTotal - 8;
            }
            else
            {
                Poke(x*2 + 1, y*2 + 1, Pixel.Unset);
            }

            // test for the bottom left corner of the 2x2 character
            if (testTotal >= 4)
            {
                Poke(x*2, y*2 + 1, Pixel.Set);
                testTotal = testTotal - 4;
            }
            else
            {
                Poke(x*2, y*2 + 1, Pixel.Unset);
            }

            // test for the top right corner of the 2x2 character
            if (testTotal >= 2)
            {
                Poke(x*2 + 1, y*2, Pixel.Set);
                testTotal = testTotal - 2;
            }
            else
            {
                Poke(x*2 + 1, y*2, Pixel.Unset);
            }

            // test for the top left corner of the 2x2 character
            if (testTotal >= 1)
            {
                Poke(x*2, y*2, Pixel.Set);
            }
            else
            {
                Poke(x*2, y*2, Pixel.Unset);
            }


        }
    }
}