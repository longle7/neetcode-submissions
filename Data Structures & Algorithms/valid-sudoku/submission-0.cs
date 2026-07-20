public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        return CheckRows(board) && CheckColumns(board) && CheckBoxes(board);
    }

    public static bool CheckRows(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            HashSet<char> myMap = new HashSet<char>();
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.') continue;

                if (!myMap.Add(board[i][j])) return false;
            }
        }
        return true;
    }

    public static bool CheckColumns(char[][] board)
    {
        for (int c = 0; c < board.Length; c++)
        {
            HashSet<char> myMap = new HashSet<char>();
            for (int r = 0; r < board[c].Length; r++)
            {
                char cur = board[r][c];

                if (cur == '.') continue;

                if (!myMap.Add(cur)) return false;
            }
        }
        return true;
    }

    public static bool CheckBoxes(char[][] board)
    {
        for (int b = 0; b <= 8; b++)
        {
            // starting r and c for that block
            int startRow = b / 3 * 3;
            int startCol = b % 3 * 3;
            HashSet<char> myMap = new HashSet<char>();
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    char cur = board[row][col];

                    if (cur == '.') continue;

                    if (!myMap.Add(cur)) return false;
                }
            }
        }
        return true;
    }
}
