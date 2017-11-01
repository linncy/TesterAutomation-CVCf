using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lrcmeteer
{
    /// <summary>  
    /// 与控制台交互  
    /// </summary>  
    static class Shell
    {
        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="format"></param>  
        /// <param name="args"></param>  
        public static void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
        }

        /// <summary>  
        /// 输出信息  
        /// </summary>  
        /// <param name="output"></param>  
        public static void WriteLine(string output)
        {
            Console.ForegroundColor = GetConsoleColor(output);
            Console.WriteLine(@"[{0}]{1}", DateTimeOffset.Now, output);
        }

        /// <summary>  
        /// 根据输出文本选择控制台文字颜色  
        /// </summary>  
        /// <param name="output"></param>  
        /// <returns></returns>  
        private static ConsoleColor GetConsoleColor(string output)
        {
            if (output.StartsWith("Error")) return ConsoleColor.Red;
            if (output.StartsWith("Find")) return ConsoleColor.Blue;
            if (output.StartsWith("[Send]")) return ConsoleColor.Green;
            if (output.StartsWith("[Receive]")) return ConsoleColor.Yellow;
            return ConsoleColor.Gray;
        }
    }
}
