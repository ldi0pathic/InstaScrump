﻿using System;

namespace InstaScrump.Common.Extension
{
    public static class ConsoleExtension
    {
        public static void WriteOnLine(this string msg, int postion, ConsoleColor color = ConsoleColor.White )
        {
            var oldPos = Console.CursorTop;

            Console.SetCursorPosition(Console.CursorLeft, postion);
            msg.Write(color);
            Console.SetCursorPosition(Console.CursorLeft, oldPos);
        }

        public static void Write(this string msg, ConsoleColor color = ConsoleColor.White)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine(">> "+msg.TrimStart(' ').PadRight(100, ' '));
            Console.ForegroundColor = oldColor;
        }
    }
}
