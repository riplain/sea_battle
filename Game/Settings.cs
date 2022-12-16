﻿namespace Game
{
    public static class Settings
    {
        public static readonly string RestartCommand = "RESTART";
        public static readonly string StopCommand = "STOP";

        public static readonly string FieldFilename = "fieldPlayer";
        public static readonly string FilesLocationDir = @"..\..\..\..\";

        public static readonly int RestartingTimeInMs = 1000;
        public static readonly int CommandDelayInMs = 150;

        public static readonly int LettersCount = 10;
        public static readonly int NumbersCount = 10;

        public static readonly int AlphabetSize = 26;

        public static readonly int CharacterOffset = 65;

        public static readonly string AxesIndent = new(' ', 1);
        public static readonly string IndentBetweenFields = new(' ', 5);
        public static readonly string IndentFromDigit = new(' ', (LettersCount - 1).Length());

        public static readonly ConsoleColor DigitsColor = ConsoleColor.White;
        public static readonly ConsoleColor LettersColor = ConsoleColor.DarkBlue;
        public static readonly ConsoleColor PlayerCaptionColor = ConsoleColor.DarkYellow;

        public static readonly ConsoleColor PlayerTurnColor = ConsoleColor.DarkYellow;
        public static readonly ConsoleColor WinnerColor = ConsoleColor.Cyan;

        public static void ResetConsoleForegroundColor() => ConsoleForegroundColor = ConsoleColor.White;
        public static ConsoleColor ConsoleForegroundColor 
        { 
            get { return ConsoleForegroundColor; } 
            set { ForegroundColor = value; } 
        }
    }
}