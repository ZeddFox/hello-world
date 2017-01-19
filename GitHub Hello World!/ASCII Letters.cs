using System;

namespace GitHub_Hello_World
{
    class ASCII_Letters
    {
        #region Letter Strings
        public static string[] H = new string[5]
        {
            "█   █",
            "█   █",
            "█████",
            "█   █",
            "█   █"
        };

        public static string[] E = new string[5]
        {
            "█████",
            "█    ",
            "█████",
            "█    ",
            "█████"
        };
        public static string[] L = new string[5]
{
            "█    ",
            "█    ",
            "█    ",
            "█    ",
            "█████"
};
        public static string[] O = new string[5]
{
            "█████",
            "█   █",
            "█   █",
            "█   █",
            "█████"
};
        public static string[] W = new string[5]
{
            "█ █ █",
            "█ █ █ ",
            "█ █ █",
            "█ █ █",
            "█████"
};
        public static string[] R = new string[5]
{
            "█████",
            "█   █",
            "█████",
            "█ █  ",
            "█   █"
};
        public static string[] D = new string[5]
{
            "████ ",
            "█   █",
            "█   █",
            "█   █",
            "████ "
            };

        public static string[] exclamationMark = new string[5]
        {
            "█",
            "█",
            "█",
            "",
            "█"
        };
        #endregion

        public void WriteOutArrayOfStrings(char inputChar, int x, int y)
        {
            #region Convertion from char to String
            string[] arrayInput = new string[5];
            if (inputChar == 'H')
            {
                arrayInput = H;
            }
            if (inputChar == 'E')
            {
                arrayInput = E;
            }
            if (inputChar == 'L')
            {
                arrayInput = L;
            }
            if (inputChar == 'O')
            {
                arrayInput = O;
            }
            if (inputChar == 'W')
            {
                arrayInput = W;
            }
            if (inputChar == 'R')
            {
                arrayInput = R;
            }
            if (inputChar == 'D')
            {
                arrayInput = D;
            }
            if (inputChar == '!')
            {
                arrayInput = exclamationMark;
            }
            #endregion

            for (int i = 0; i < arrayInput.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(arrayInput[i]);
            }
        }
    }
}
