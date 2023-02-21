namespace Blocks
{
    public enum Pixel
    {
        Set = 1,
        Unset = 0
    }

    public class VirtualScreen
    {
#region private attributes

        private Pixel[,] _virtualScreen;
        private int _max_x;
        private int _max_y;
#endregion private attributes

#region basic functions
        /// <summary>
        /// Creates a class to represent the virtual screen
        /// </summary>
        /// <param name="x">Size of the x axis</param>
        /// <param name="y">Size of the y axis</param>
        public  VirtualScreen(int x, int y)
        {
            _virtualScreen = new Pixel[x,y];
            _max_x = x - 1;
            _max_y = y - 1;
        }

        /// <summary>
        /// Pokes the newValue into the virtual screen
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <param name="newValue">either Set or Unset the postion</param>
        public void Poke(int x, int y, Pixel newValue)
        {
            if ((x > 0) && (x <= _max_x) && (y > 0) && (y <= _max_y))
                _virtualScreen[x,y] = newValue;
        }

        /// <summary>
        /// Peeks the value at location x,y
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        /// <returns>the value of the pixel at the location</returns>
        public Pixel Peek(int x, int y)
        {
            if ((x > 0) && (x <= _max_x) && (y > 0) && (y <= _max_y))
                return _virtualScreen[x,y];
            else
                return Pixel.Unset;
        }

#endregion basic functions

    }
}