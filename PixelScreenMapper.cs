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

        public void PrintCharacterAt (int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(MapPixelsToConsoleCharacter(x ,y));
        }
    }
}