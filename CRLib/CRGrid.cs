using System;

namespace CRLib
{
    public class CRGrid
    {
        #region Values
        readonly Random rnd = new Random();
        readonly protected int side;
        protected int[,] grid;
        protected int[,] dir;
        protected int curY;
        protected int curX;
        protected int prevY;
        protected int prevX;
        protected bool solvingAllowed;
        #endregion
        #region Properties
        public int Side { get => side; }
        public bool SolvingAllowed
        {
            get => solvingAllowed;
            set => solvingAllowed = value;
        }
        #endregion
        #region Constructors
        public CRGrid(int side)
        {
            solvingAllowed = false;
            if (side < 0 || side % 2 != 0)
                throw new ArgumentException("Height or weight can't be negative");
            this.side = side;

            grid = new int[side, side];
            dir = new int[side, side];

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                    grid[i, j] = 0;
            }

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                    dir[i, j] = 0;
            }
        }
        public CRGrid(int side, params CRPoint[] points) : this(side)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].Y > this.side || points[i].X > this.side)
                    throw new ArgumentException("The point is out of the grid's coordinates");
                dir[points[i].Y, points[i].X] = points[i].State;
            }
        }
        #endregion
        #region Solvers
        /// <summary>
        /// Solves the grid (if possible)
        /// </summary>
        /// <returns>Returns true if the grid is solvable</returns>
        public virtual bool Solve()
        {
            CleanGrid();
            grid[0, 0] = 41;
            return (TrySolve(0, 1, grid[0, 0]));
        }
        /// <summary>
        /// Goes through all the possible moves for a cell in the grid
        /// </summary>
        /// <param name="curY">The Y axis of the cell</param>
        /// <param name="curX">The X axis of the cell</param>
        /// <param name="enterDir">The entering direction of the cell</param>
        /// <returns>Returns true if the grid is solved</returns>
        private bool TrySolve(int curY, int curX, int enterDir)
        {
            if (!solvingAllowed)
                return false;
            int curDir = ((enterDir % 10 + 1) % 4 + 1) * 10;
            if (curY < 0 || curX < 0)
                return false;
            if (curY >= side || curX >= side)
                return false;
            if (grid[1, 0] == 14 || grid[1, 0] == 41)
                return false;
            if (curY == 0 && curX == 0 && CheckAll())
                return true;
            if (grid[curY, curX] != 0)
                return false;
            if (!CheckBorders())
                return false;
            if (!CheckCrosshairs())
                return false;

            int[] possDir = GetPossDir(curDir / 10, curY, curX);
            for (int i = 0; i < possDir.Length; i++)
            {
                grid[curY, curX] = curDir + possDir[i];

                if (YMod(grid[curY, curX] % 10) == 2 || XMod(grid[curY, curX] % 10) == 2)
                    throw new Exception("Something wrong in xMod and yMod");

                if (TrySolve(curY + YMod(grid[curY, curX] % 10), curX + XMod(grid[curY, curX] % 10), grid[curY, curX]))
                    return true;
            }

            grid[curY, curX] = 0;
            return false;
        }
        /// <summary>
        /// Calculates all the possible moves for a cell in the grid
        /// </summary>
        /// <param name="enterPoint">The entering direction of the cell</param>
        /// <param name="y">The Y axis of the cell</param>
        /// <param name="x">The X axis of the cell</param>
        /// <returns>All the possible directions</returns>
        private int[] GetPossDir(int enterPoint, int y, int x)
        {
            int[] result;
            if (dir[y, x] == 0)
            {
                result = new int[3];
                for (int i = 0; i < 3; i++)
                    result[2 - i] = (enterPoint + i) % 4 + 1;
                return result;
            }
            else if (dir[y, x] == 1)
            {
                result = new int[2];
                result[0] = enterPoint % 4 + 1;
                result[1] = (enterPoint + 2) % 4 + 1;
            }
            else if (dir[y, x] == 2)
            {
                result = new int[1];
                result[0] = (enterPoint + 1) % 4 + 1;
            }
            else throw new ArgumentException("Unidentified point in directions");
            return result;
        }
        /// <summary>
        /// Checks if the grid is filled
        /// </summary>
        /// <returns>Returns true if the grid is complete</returns>
        protected bool CheckAll()
        {
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    if (grid[i, j] == 0)
                        return false;
            return true;
        }
        /// <summary>
        /// Checks for any inconsistancies in the borders of the grid
        /// </summary>
        /// <returns>Returns true if borders are alright</returns>
        bool CheckBorders()
        {
            for (int i = 1; i < side - 1; i++)
            {
                if (grid[0, i] == 0 && grid[0, i - 1] != 0 && grid[0, i + 1] != 0 && grid[1, i] != 0)
                    return false;
                if (grid[side - 1, i] == 0 && grid[side - 1, i - 1] != 0 && grid[side - 1, i + 1] != 0 && grid[side - 2, i] != 0)
                    return false;
                if (i != 1 && grid[i, 0] == 0 && grid[i - 1, 0] != 0 && grid[i + 1, 0] != 0 && grid[i, 1] != 0)
                    return false;
                if (grid[i, side - 1] == 0 && grid[i - 1, side - 1] != 0 && grid[i + 1, side - 1] != 0 && grid[i, side - 2] != 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Checks for any inconsistancies in the crosshairs of the grid
        /// </summary>
        /// <returns>Returns true if all crosshairs are alright</returns>
        bool CheckCrosshairs()
        {
            for (int i = 1; i < side - 1; i++)
            {
                for (int j = 1; j < side - 1; j++)
                {
                    if (grid[i, j] == 0 && grid[i + 1, j] != 0 && grid[i, j + 1] != 0 && grid[i - 1, j] != 0 && grid[i, j - 1] != 0)
                        return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Calculates the Y modifier
        /// </summary>
        /// <param name="y">The Y axis</param>
        /// <returns>Returns the correct modifier</returns>
        static int YMod(int y)
        {
            if (y < 0 || y > 4)
                throw new ArgumentException("y is out of boundry [1, 4]");
            switch (y)
            {
                case 1:
                    return 0;
                case 2:
                    return -1;
                case 3:
                    return 0;
                case 4:
                    return 1;
                default:
                    return 2;
            }
        }
        /// <summary>
        /// Calculates the X modifier
        /// </summary>
        /// <param name="x">The X axis</param>
        /// <returns>The correct modifier</returns>
        static int XMod(int x)
        {
            if (x < 0 || x > 4)
                throw new ArgumentException("x is out of boundry [1, 4]");
            switch (x)
            {
                case 1:
                    return 1;
                case 2:
                    return 0;
                case 3:
                    return -1;
                case 4:
                    return 0;
                default:
                    return 2;
            }
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Cleans the grid
        /// </summary>
        public virtual void CleanGrid()
        {
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    grid[i, j] = 0;
        }
        /// <summary>
        /// Cleans the directions grid
        /// </summary>
        public virtual void CleanDirections()
        {
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                    dir[i, j] = 0;
        }
        /// <summary>
        /// Converts the grid to string
        /// </summary>
        /// <returns>Returs the grid as a string</returns>
        public string GetGrid()
        {
            string res = "";
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                    res += grid[i, j] + "  ";
                res += "\n";
            }
            return res;
        }
        /// <summary>
        /// Converts the direction grid to string
        /// </summary>
        /// <returns>Returns the direction grid as a string</returns>
        public string GetDir()
        {
            string res = "";
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                    res += dir[i, j] + "  ";
                res += "\n";
            }
            return res;
        }
        /// <summary>
        /// Resets the current position
        /// </summary>
        public void ResetPos()
        {
            curX = 0;
            curY = 0;
        }
        /// <summary>
        /// Randomizes the direction grid
        /// </summary>
        public void RandomizeDir()
        {
            int rValue;
            do
            {
                for (int i = 0; i < side; i++)
                {
                    for (int j = 0; j < side; j++)
                    {
                        rValue = rnd.Next(0, 21);
                        if (rValue <= 10)
                            dir[i, j] = 0;
                        else
                        {
                            if (rValue <= 15)
                                dir[i, j] = 1;
                            else dir[i, j] = 2;
                        }
                    }
                }
                dir[0, 0] = 0;
                dir[0, side - 1] = 0;
                dir[side - 1, 0] = 0;
                dir[side - 1, side - 1] = 0;
            } while (!Solve());
        }
        #endregion
    }
}
