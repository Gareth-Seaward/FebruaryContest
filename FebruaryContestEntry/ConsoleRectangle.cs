using System;

namespace FebruaryContestEntry
{
    public static class ConsoleRectangle
    {
        private static string _buildingBlock = " ";

        public static void Draw(int width, int height)
        {
            for (int rowIndex = 0; rowIndex < height; rowIndex++)
            {
                DrawRow(width, height, rowIndex);
                ResetToNewLine();
            }
        }

        public static void Draw(int width, int height, string block)
        {
            _buildingBlock = block;
            Draw(width,height);
        }

        private static void DrawRow(int width, int height, int rowIndex)
        {
            for (int columnIndex = 0; columnIndex < width; columnIndex++)
            {
                if (IsBorder(width, height, rowIndex, columnIndex))
                    DrawBorderBlock();
                else
                    DrawFillBlock();
            }
        }

        private static bool IsBorder(int width, int height, int rowIndex, int columnIndex)
        {
            return IsBorderRow(height, rowIndex) || IsBorderColumn(width, columnIndex);
        }

        private static bool IsBorderRow(int height, int rowIndex)
        {
            return IsTopRow(rowIndex) || IsBottomRow(height, rowIndex);
        }

        private static bool IsTopRow(int rowIndex)
        {
            return rowIndex == 0;
        }

        private static bool IsBottomRow(int height, int rowIndex)
        {
            return rowIndex == (height - 1);
        }

        private static bool IsBorderColumn(int width, int columnIndex)
        {
            return IsLeftColumn(columnIndex) || IsRightColumn(width, columnIndex);
        }

        private static bool IsLeftColumn(int columnIndex)
        {
            return columnIndex == 0;
        }

        private static bool IsRightColumn(int width, int columnIndex)
        {
            return columnIndex == (width - 1);
        }

        private static void DrawBorderBlock()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_buildingBlock);
        }

        private static void DrawFillBlock()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(_buildingBlock);
        }

        private static void ResetToNewLine()
        {
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}