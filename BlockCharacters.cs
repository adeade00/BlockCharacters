namespace Blocks
{
    /// <summary>
    /// Holds the data mappings between Pixel Blocks and printable characters 
    /// </summary>
    static class BlockCharacters
    {
        /// <summary>
        /// Maps an integer (binary converted to decimal) to the unicode block character
        /// </summary>
        /// <remarks>
        /// <para>
        /// so a 2x2 square that makes up a block character can be thought of being made up as follows:
        /// </para>
        /// <para>
        /// top left - Units
        /// </para>
        /// <para>
        /// top right - Twos
        /// </para>
        /// <para>
        /// bottom left - Fours
        /// </para>
        /// <para>
        /// bottom right - Eights
        /// </para>
        /// </remarks>
        static public Dictionary<int,string> DecimalToUnicode = new Dictionary<int,string>()
        {
            {0 ,"\u0020"}, //blank space         
            {1 ,"\u2598"}, //top left           ▘
            {2 ,"\u259d"}, //top right          ▝
            {3 ,"\u2580"}, //top half           ▀
            {4 ,"\u2596"}, //bottom left        ▖
            {5 ,"\u258c"}, //left half          ▌
            {6 ,"\u259e"}, //right diagonal     ▞
            {7 ,"\u259b"}, //top left 3/4       ▛
            {8 ,"\u2597"}, //bottom right       ▗
            {9 ,"\u259a"}, //left diagonal      ▚
            {10,"\u2590"}, //right half         ▐
            {11,"\u259c"}, //top right 3/4      ▜
            {12,"\u2584"}, //bottom half        ▄
            {13,"\u2599"}, //bottom left 3/4    ▙
            {14,"\u259f"}, //bottom righ 3/4    ▟
            {15,"\u2588"}, //full block         █
        };
        
    }

    /// <summary>
    /// Maps name to decimal number
    /// </summary>
    public enum ConsoleShapeToDecimal
    {
        blank_space         = 0,
        top_left            = 1,
        top_right           = 2,
        top_half            = 3,
        bottom_left         = 4,
        left_half           = 5,
        right_diagonal      = 6,
        top_left_3          = 7,
        bottom_right        = 8,
        left_diagonal       = 9,
        right_half          = 10,
        top_right_3         = 11,
        bottom_half         = 12,
        bottom_left_3       = 13,
        bottom_right_3      = 14,
        full_block          = 15
    }
}