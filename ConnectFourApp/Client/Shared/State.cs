namespace ConnectFourApp.Client.Shared
{

    public class State
    {
        static State()
        {
            CalculateWinningCells();
        }

        public enum WinState
        {
            No_Winner = 0,
            Player1_Wins = 1,
            Player2_Wins = 2,
            Draw = 3
        }

        public int CurrentPlayer => GameBoard.Count(x => x != 0) % 2 + 1;

        public int CurrentTurn { get { return GameBoard.Count(x => x != 0); } }

        public static readonly List<int[]> WinningCells = new();

        public static void CalculateWinningCells()
        {
            for (byte row = 0; row < 6; row++)
            {

                byte rowColumn1 = (byte)(row * 7);
                byte rowColumn7 = (byte)((row + 1) * 7 - 1);
                byte checkColumn = rowColumn1;
                while (checkColumn <= rowColumn7 - 3)
                {
                    WinningCells.Add(new int[] {
                                        checkColumn,
                                        (byte)(checkColumn + 1),
                                        (byte)(checkColumn + 2),
                                        (byte)(checkColumn + 3)
                                });
                    checkColumn++;
                }

            }

            for (byte column = 0; column < 7; column++)
            {

                byte columnRow1 = column;
                byte columnRow7 = (byte)(35 + column);
                byte checkRow = columnRow1;
                while (checkRow <= 14 + column)
                {
                    WinningCells.Add(new int[] {
                                        checkRow,
                                        (byte)(checkRow + 7),
                                        (byte)(checkRow + 14),
                                        (byte)(checkRow + 21)
                                });
                    checkRow += 7;
                }

            }

            for (byte column = 0; column < 4; column++)
            {

                byte columnRow1 = (byte)(21 + column);
                byte columnRow7 = (byte)(35 + column);
                byte checkPosition = columnRow1;
                while (checkPosition <= columnRow7)
                {
                    WinningCells.Add(new int[] {
                                        checkPosition,
                                        (byte)(checkPosition - 6),
                                        (byte)(checkPosition - 12),
                                        (byte)(checkPosition - 18)
                                });
                    checkPosition += 7;
                }

            }

            for (byte column = 0; column < 4; column++)
            {

                byte columnRow1 = (byte)(0 + column);
                byte columnRow7 = (byte)(14 + column);
                byte checkPosition = columnRow1;
                while (checkPosition <= columnRow7)
                {
                    WinningCells.Add(new int[] {
                                        checkPosition,
                                        (byte)(checkPosition + 8),
                                        (byte)(checkPosition + 16),
                                        (byte)(checkPosition + 24)
                                });
                    checkPosition += 7;
                }

            }

        }

        public WinState CheckForWin()
        {
            if (GameBoard.Count(x => x != 0) < 7) return WinState.No_Winner;

            foreach (var option in WinningCells)
            {
                if (GameBoard[option[0]] == 0) continue;

                if (GameBoard[option[0]] ==
                    GameBoard[option[1]] &&
                    GameBoard[option[1]] ==
                    GameBoard[option[2]] &&
                    GameBoard[option[2]] ==
                    GameBoard[option[3]]) return (WinState)GameBoard[option[0]];
            }

            if (GameBoard.Count(x => x != 0) == 42) return WinState.Draw;

            return WinState.No_Winner;
        }

        public byte PlayPiece(int column)
        {
            if (CheckForWin() != 0) throw new ArgumentException("Game is over");

            if (GameBoard[column] != 0) throw new ArgumentException("Column is full");

            var playedCell = column;
            for (var i = column; i < 42; i += 7)
            {
                if (GameBoard[playedCell + 7] != 0) break;
                playedCell = i;
            }

            GameBoard[playedCell] = CurrentPlayer;

            return ConvertPlayedCellToRow(playedCell);

        }

        public List<int> GameBoard { get; private set; } = new List<int>(new int[42]);

        public void ResetBoard()
        {
            GameBoard = new List<int>(new int[42]);
        }

        private byte ConvertPlayedCellToRow(int playedCell) => (byte)(Math.Floor(playedCell / (decimal)7) + 1);

    }
}