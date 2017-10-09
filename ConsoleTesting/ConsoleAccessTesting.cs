using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTesting
{
    class ConsoleAccessTesting
    {
        static public int BufferHeight = 25;
        static public int BufferWidth = 80;

        static public void ControlCursor(ConsoleColor baseColor, int startX, int startY)
        {
            var originalColor = Console.BackgroundColor;
            Console.BackgroundColor = baseColor;

            int xPos = startX;
            int yPos = startY;

            bool[][] characterSprite = new bool[7][];

            bool[,] testing = new bool[7, 9];

            Console.Write(testing.GetUpperBound(1));

            characterSprite[0] = new bool[9] { false, false, true, true, true, true, true,false, false };
            characterSprite[1] = new bool[9] { false, true, false, false, false, false, false, true, false };
            characterSprite[2] = new bool[9] { true, true, false, true, false, true, false, true, true};
            characterSprite[3] = new bool[9] { true, false, true, false, false, false, true, false, true };
            characterSprite[4] = new bool[9] { true, true, false, true, true, true, false, true, true };
            characterSprite[5] = new bool[9] { false, true, false, false, false, false, false, true, false };
            characterSprite[6] = new bool[9] { false, false, true, true, true, true, true, false, false };

            int characterXOffset = characterSprite.Length % 2 + characterSprite.Length / 2;
            int characterYOffset = characterSprite[0].Length % 2 + characterSprite[0].Length / 2;

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            
            do
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Backspace:
                        break;
                    case ConsoleKey.Tab:
                        break;
                    case ConsoleKey.Clear:
                        break;
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Pause:
                        break;
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(' ');
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.PageUp:
                        break;
                    case ConsoleKey.PageDown:
                        break;
                    case ConsoleKey.End:
                        break;
                    case ConsoleKey.Home:
                        break;
                    case ConsoleKey.LeftArrow:
                        if(Console.CursorLeft > 0)
                        {
                            Console.Write(' ');
                            DrawCharacter(xPos, yPos, baseColor, ConsoleColor.Gray, characterSprite);
                            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if(Console.CursorTop > 0)
                        {
                            Console.Write(' ');
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft <BufferWidth)
                        {
                            Console.Write(' ');
                            //Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(Console.CursorTop < BufferHeight)
                        {
                            Console.Write(' ');
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                        }
                        break;
                    case ConsoleKey.Select:
                        break;
                    case ConsoleKey.Print:
                        break;
                    case ConsoleKey.Execute:
                        break;
                    case ConsoleKey.PrintScreen:
                        break;
                    case ConsoleKey.Insert:
                        break;
                    case ConsoleKey.Delete:
                        break;
                    case ConsoleKey.Help:
                        break;
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.D9:
                        break;
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.B:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case ConsoleKey.C:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        break;
                    case ConsoleKey.D:
                        break;
                    case ConsoleKey.E:
                        break;
                    case ConsoleKey.F:
                        break;
                    case ConsoleKey.G:
                        break;
                    case ConsoleKey.H:
                        break;
                    case ConsoleKey.I:
                        break;
                    case ConsoleKey.J:
                        break;
                    case ConsoleKey.K:
                        break;
                    case ConsoleKey.L:
                        break;
                    case ConsoleKey.M:
                        break;
                    case ConsoleKey.N:
                        break;
                    case ConsoleKey.O:
                        break;
                    case ConsoleKey.P:
                        break;
                    case ConsoleKey.Q:
                        break;
                    case ConsoleKey.R:
                        break;
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.T:
                        break;
                    case ConsoleKey.U:
                        break;
                    case ConsoleKey.V:
                        break;
                    case ConsoleKey.W:
                        break;
                    case ConsoleKey.X:
                        break;
                    case ConsoleKey.Y:
                        break;
                    case ConsoleKey.Z:
                        break;
                    case ConsoleKey.LeftWindows:
                        break;
                    case ConsoleKey.RightWindows:
                        break;
                    case ConsoleKey.Applications:
                        break;
                    case ConsoleKey.Sleep:
                        break;
                    case ConsoleKey.NumPad0:
                        break;
                    case ConsoleKey.NumPad1:
                        break;
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.NumPad4:
                        break;
                    case ConsoleKey.NumPad5:
                        break;
                    case ConsoleKey.NumPad6:
                        break;
                    case ConsoleKey.NumPad7:
                        break;
                    case ConsoleKey.NumPad8:
                        break;
                    case ConsoleKey.NumPad9:
                        break;
                    case ConsoleKey.Multiply:
                        break;
                    case ConsoleKey.Add:
                        break;
                    case ConsoleKey.Separator:
                        break;
                    case ConsoleKey.Subtract:
                        break;
                    case ConsoleKey.Decimal:
                        break;
                    case ConsoleKey.Divide:
                        break;
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:
                        break;
                    case ConsoleKey.F3:
                        break;
                    case ConsoleKey.F4:
                        break;
                    case ConsoleKey.F5:
                        break;
                    case ConsoleKey.F6:
                        break;
                    case ConsoleKey.F7:
                        break;
                    case ConsoleKey.F8:
                        break;
                    case ConsoleKey.F9:
                        break;
                    case ConsoleKey.F10:
                        break;
                    case ConsoleKey.F11:
                        break;
                    case ConsoleKey.F12:
                        break;
                    case ConsoleKey.F13:
                        break;
                    case ConsoleKey.F14:
                        break;
                    case ConsoleKey.F15:
                        break;
                    case ConsoleKey.F16:
                        break;
                    case ConsoleKey.F17:
                        break;
                    case ConsoleKey.F18:
                        break;
                    case ConsoleKey.F19:
                        break;
                    case ConsoleKey.F20:
                        break;
                    case ConsoleKey.F21:
                        break;
                    case ConsoleKey.F22:
                        break;
                    case ConsoleKey.F23:
                        break;
                    case ConsoleKey.F24:
                        break;
                    case ConsoleKey.BrowserBack:
                        break;
                    case ConsoleKey.BrowserForward:
                        break;
                    case ConsoleKey.BrowserRefresh:
                        break;
                    case ConsoleKey.BrowserStop:
                        break;
                    case ConsoleKey.BrowserSearch:
                        break;
                    case ConsoleKey.BrowserFavorites:
                        break;
                    case ConsoleKey.BrowserHome:
                        break;
                    case ConsoleKey.VolumeMute:
                        break;
                    case ConsoleKey.VolumeDown:
                        break;
                    case ConsoleKey.VolumeUp:
                        break;
                    case ConsoleKey.MediaNext:
                        break;
                    case ConsoleKey.MediaPrevious:
                        break;
                    case ConsoleKey.MediaStop:
                        break;
                    case ConsoleKey.MediaPlay:
                        break;
                    case ConsoleKey.LaunchMail:
                        break;
                    case ConsoleKey.LaunchMediaSelect:
                        break;
                    case ConsoleKey.LaunchApp1:
                        break;
                    case ConsoleKey.LaunchApp2:
                        break;
                    case ConsoleKey.Oem1:
                        break;
                    case ConsoleKey.OemPlus:
                        break;
                    case ConsoleKey.OemComma:
                        break;
                    case ConsoleKey.OemMinus:
                        break;
                    case ConsoleKey.OemPeriod:
                        break;
                    case ConsoleKey.Oem2:
                        break;
                    case ConsoleKey.Oem3:
                        break;
                    case ConsoleKey.Oem4:
                        break;
                    case ConsoleKey.Oem5:
                        break;
                    case ConsoleKey.Oem6:
                        break;
                    case ConsoleKey.Oem7:
                        break;
                    case ConsoleKey.Oem8:
                        break;
                    case ConsoleKey.Oem102:
                        break;
                    case ConsoleKey.Process:
                        break;
                    case ConsoleKey.Packet:
                        break;
                    case ConsoleKey.Attention:
                        break;
                    case ConsoleKey.CrSel:
                        break;
                    case ConsoleKey.ExSel:
                        break;
                    case ConsoleKey.EraseEndOfFile:
                        break;
                    case ConsoleKey.Play:
                        break;
                    case ConsoleKey.Zoom:
                        break;
                    case ConsoleKey.NoName:
                        break;
                    case ConsoleKey.Pa1:
                        break;
                    case ConsoleKey.OemClear:
                        break;
                    default:
                        break;
                }
                //Console.WriteLine(keyInfo.Key + " was pressed.");
            } while (keyInfo.Key != ConsoleKey.X);

            Console.BackgroundColor = originalColor;
        }

        private static void DrawCharacter(int xPos, int yPos, ConsoleColor windowBackground, ConsoleColor characterColor, bool[][] sprite)
        {
            Console.Write(sprite.Length);
            foreach (var item in sprite)
            {
                foreach (var innerItem in item)
                {
                    if(innerItem.Equals(true))
                    {
                        Console.BackgroundColor = characterColor;
                        Console.Write(' ');
                        Console.BackgroundColor = windowBackground;
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.SetCursorPosition(Console.CursorLeft - item.Length, Console.CursorTop + 1);
            }
        }

        public ConsoleAccessTesting()
        {
        }
    }
}
