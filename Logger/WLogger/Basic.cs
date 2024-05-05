using System;
using System.Runtime.InteropServices;

namespace WLogger
{
    public class Basic
    {
        #region Imports
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
        #endregion

        #region Other var
        private const int STD_OUTPUT_HANDLE = -11;
        private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;
        #endregion

        /// <summary>
        /// To make it work lol :D
        /// </summary>
        public static void Install()
        {
            var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            uint mode;
            GetConsoleMode(handle, out mode);
            mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
            SetConsoleMode(handle, mode);
        }

        public class WColors
        {
            public const string UNDERLINE = "\x1B[4m";
            public const string RESET = "\x1B[0m";
            public const string BLACK = "\u001b[30m";
            public const string RED = "\u001b[31m";
            public const string GREEN = "\u001b[32m"; 
            public const string LIME = "\u001b[32;1m";
            public const string YELLOW = "\u001b[33m";
            public const string LEMON = "\u001b[33;1m";
            public const string BLUE = "\u001b[34m";
            public const string PURPLE = "\u001b[35m";
            public const string PURPLEPLUS = "\u001b[35;1m";
            public const string AQUA = "\u001b[36m";
            public const string WHITE = "\u001b[37m";
        }



        public static void Info(string information, bool dateTime = true)
        {
            if (dateTime) { Console.WriteLine($"{WColors.RESET}[{DateTime.Now}] {WColors.LIME}INFO{WColors.RESET}: " + information); }
            else { Console.WriteLine($"{WColors.LIME}INFO{WColors.RESET}: " + information); }
        }

        public static void Warn(string warning, bool dateTime = true)
        {
            if (dateTime) { Console.WriteLine($"{WColors.RESET}[{DateTime.Now}] {WColors.YELLOW}WARNING{WColors.RESET}: " + warning); }
            else { Console.WriteLine($"{WColors.YELLOW}WARNING{WColors.RESET}: " + warning); }

        }

        public static void Error(string error, bool dateTime = true)
        {
            if (dateTime) { Console.WriteLine($"{WColors.RESET}[{DateTime.Now}] {WColors.RED}ERROR{WColors.RESET}: " + error); }
            else { Console.WriteLine($"{WColors.RED}ERROR{WColors.RESET}: " + error); }
        }

        public static void Debug(string error, bool dateTime = true)
        {
            if (dateTime) { Console.WriteLine($"{WColors.RESET}[{DateTime.Now}] {WColors.PURPLEPLUS}DEBUG{WColors.RESET}: " + error); }
            else { Console.WriteLine($"{WColors.PURPLEPLUS}DEBUG{WColors.RESET}: " + error); }
        }
    }
}
