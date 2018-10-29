namespace Sandbar
{
    public struct AnimationPattern
    {
        /// <summary>
        /// The spinner, ASCII supported.
        /// </summary>
        public static readonly string Spinner = @"|/-\";

        /// <summary>
        /// The PBDQ, ASCII supported.
        /// </summary>
        public static readonly string Pbdq = "pbdq";

        /// <summary>
        /// The balloon popping, ASCII supported.
        /// </summary>
        public static readonly string Balloon = ".oO@*";

        /// <summary>
        /// A bouncy ball, requires unicode support.
        /// </summary>
        public static readonly string Bounce = @"⠁⠂⠄⡀⢀⠠⠐⠈";

        /// <summary>
        /// Hello World in braille, requires unicode support.
        /// </summary>
        public static readonly string HelloBraille = @"⠠⠓⠑⠇⠇⠕⠠⠺⠕⠗⠇⠙";

        /// <summary>
        /// The roto braille display, requires unicode support.
        /// </summary>
        public static readonly string RotoBraille = @"⣾⣽⣻⢿⡿⣟⣯⣷";

        /// <summary>
        /// Braille display, requires unicode support.
        /// </summary>
        public static readonly string Braille =
            @"⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋⡌⡍⡎⡏⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩⡪⡫⡬⡭⡮⡯⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏⢐⢑⢒⢓⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟⢠⢡⢢⢣⢤⢥⢦⢧⢨⢩⢪⢫⢬⢭⢮⢯⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿";

        /// <summary>
        /// Pie animation, requires unicode support.
        /// </summary>
        public static readonly string Pies = @"◴◷◶◵";
    }
}