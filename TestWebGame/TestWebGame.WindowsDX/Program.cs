﻿using System;

namespace TestWebGame
{
#if  WINDOWSDX || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new TestWebGameGame())
                game.Run();
        }
    }
#endif
}
