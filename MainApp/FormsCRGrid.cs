using System;
using System.IO;
using CRLib;
using System.Drawing;
using System.Web.Script.Serialization;

namespace MainApp
{
    public class FormsCRGrid : CRGrid
    {
        #region Static Values
        private static readonly string ImagesPath = "images/";
        private static Bitmap[][] gridImages;
        private static Bitmap[] dirImages;
        #endregion
        #region Properties
        public int[,] Directions { get => dir; }
        public int[,] Grid { get => grid; }
        #endregion
        #region Constructors
        static FormsCRGrid()
        {
            LoadImages();
        }
        public FormsCRGrid(int side) : base(side) {}
        #endregion
        #region Static Methods
        /// <summary>
        /// Loads all the images
        /// </summary>
        static void LoadImages()
        {
            dirImages = new Bitmap[3];
            for (int i = 0; i < 3; i++)
                dirImages[i] = new Bitmap(string.Concat(ImagesPath, $"gr0_{i}.jpg"));

            gridImages = new Bitmap[41][];
            for (int i = 0; i < 41; i++)
                gridImages[i] = new Bitmap[3];

            gridImages[0][0] = GetGridImage(0, 0);
            gridImages[0][1] = GetGridImage(0, 1);
            gridImages[0][2] = GetGridImage(0, 2);

            gridImages[10][0] = GetGridImage(10, 0);
            gridImages[10][1] = GetGridImage(10, 1);
            gridImages[10][2] = GetGridImage(10, 2);

            gridImages[12][0] = GetGridImage(12, 0);
            gridImages[12][1] = GetGridImage(12, 1);
            gridImages[12][2] = GetGridImage(12, 2);

            gridImages[13][0] = GetGridImage(13, 0);
            gridImages[13][1] = GetGridImage(13, 1);
            gridImages[13][2] = GetGridImage(13, 2);

            gridImages[14][0] = GetGridImage(14, 0);
            gridImages[14][1] = GetGridImage(14, 1);
            gridImages[14][2] = GetGridImage(14, 2);

            gridImages[20][0] = GetGridImage(20, 0);
            gridImages[20][1] = GetGridImage(20, 1);
            gridImages[20][2] = GetGridImage(20, 2);

            gridImages[23][0] = GetGridImage(23, 0);
            gridImages[23][1] = GetGridImage(23, 1);
            gridImages[23][2] = GetGridImage(23, 2);

            gridImages[24][0] = GetGridImage(24, 0);
            gridImages[24][1] = GetGridImage(24, 1);
            gridImages[24][2] = GetGridImage(24, 2);

            gridImages[30][0] = GetGridImage(30, 0);
            gridImages[30][1] = GetGridImage(30, 1);
            gridImages[30][2] = GetGridImage(30, 2);

            gridImages[34][0] = GetGridImage(34, 0);
            gridImages[34][1] = GetGridImage(34, 1);
            gridImages[34][2] = GetGridImage(34, 2);

            gridImages[40][0] = GetGridImage(40, 0);
            gridImages[40][1] = GetGridImage(40, 1);
            gridImages[40][2] = GetGridImage(40, 2);
        }
        /// <summary>
        /// Loads the grid image
        /// </summary>
        /// <param name="num">The direction of the cell</param>
        /// <param name="state">The state of the direction grid</param>
        /// <returns></returns>
        public static Bitmap GetGridImage(int num, int state)
        {
            return new Bitmap(string.Concat(ImagesPath, $"gr{num}_{state}.jpg"));
        }
        /// <summary>
        /// Turns an array into a matrix
        /// </summary>
        /// <param name="arr">The original array</param>
        /// <returns>The array as a matrix</returns>
        static int[,] TurnToMatrix(int[] arr)
        {
            int val = (int)Math.Sqrt(arr.Length);
            int[,] result = new int[(int)Math.Sqrt(arr.Length), (int)Math.Sqrt(arr.Length)];
            for (int i = 0; i < result.Length; i++)
                result[i / val, i % val] = arr[i];
            return result;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Saves the direction array to the path
        /// </summary>
        /// <param name="path">The path to the file</param>
        public void SaveDirections(string path)
        {
            File.WriteAllText(path, new JavaScriptSerializer().Serialize(dir));
        }
        /// <summary>
        /// Loads the direction matrix from the path
        /// </summary>
        /// <param name="path">The path to the file</param>
        /// <param name="side">The side of the matrix</param>
        public void LoadDirections(string path, int side)
        {
            int[,] t = TurnToMatrix(new JavaScriptSerializer().Deserialize<int[]>(File.ReadAllText(path)));
            if (t.Length != side * side)
                throw new Exception();
            dir = t;
        }
        /// <summary>
        /// Gets the picture for the direction grid cell
        /// </summary>
        /// <param name="i">The Y axis of the cell</param>
        /// <param name="j">The X axis of the cell</param>
        /// <returns></returns>
        public Bitmap GetDirPic(int i, int j) => dirImages[dir[i, j]];
        /// <summary>
        /// Gets the picture for the grid cell
        /// </summary>
        /// <param name="i">The Y axis of the cell</param>
        /// <param name="j">The X axis of the cell</param>
        /// <returns></returns>
        public Bitmap GetGridPic(int i, int j)
        {
            int num = grid[i, j];
            if (num / 10 == 0 || num % 10 == 0)
                return gridImages[grid[i, j]][dir[i, j]];
            if (num / 10 > num % 10)
                return gridImages[grid[i, j] % 10 * 10 + grid[i, j] / 10][dir[i, j]];
            else return gridImages[grid[i, j]][dir[i, j]];
        }
        #region User Controls
        /// <summary>
        /// Moves the current location right
        /// </summary>
        public void GoRight()
        {
            if (curX != side - 1)
            {
                if (dir[curY, curX] == 1 && (grid[curY, curX] / 10 == 3))
                    return;
                if (dir[curY, curX] == 2 && (grid[curY, curX] / 10 == 2 || grid[curY, curX] / 10 == 4))
                    return;
                if (curY == prevY && curX + 1 == prevX)
                {
                    RollBack();
                    if (curY == 0 && curX == 0)
                        return;
                }
                else if (grid[curY, curX + 1] == 0)
                {
                    SetPrev();
                    ++curX;
                    if (prevY != 0 || prevX != 0)
                        grid[prevY, prevX] += 1;
                    grid[curY, curX] = 30;
                }
            }
        }
        /// <summary>
        /// Moves the current location down
        /// </summary>
        public void GoDown()
        {
            if (curY != side - 1)
            {
                if (dir[curY, curX] == 1 && (grid[curY, curX] / 10 == 2))
                    return;
                if (dir[curY, curX] == 2 && (grid[curY, curX] / 10 == 1 || grid[curY, curX] / 10 == 3))
                    return;
                if (curY + 1 == prevY && curX == prevX)
                {
                    RollBack();
                    if (curY == 0 && curX == 0)
                        return;
                }
                else if (grid[curY + 1, curX] == 0)
                {
                    SetPrev();
                    ++curY;
                    if (prevY != 0 || prevX != 0)
                        grid[prevY, prevX] += 4;
                    grid[curY, curX] = 20;
                }
            }

        }
        /// <summary>
        /// Moves the current location left
        /// </summary>
        public bool GoLeft()
        {
            if (curX != 0)
            {
                if (dir[curY, curX] == 1 && (grid[curY, curX] / 10 == 1))
                    return false;
                if (dir[curY, curX] == 2 && (grid[curY, curX] / 10 == 2 || grid[curY, curX] / 10 == 4))
                    return false;
                if (curY == prevY && curX - 1 == prevX)
                {
                    RollBack();
                    if (curY == 0 && curX == 0)
                        return false;
                }
                else if (curY == 0 && curX - 1 == 0 && CheckAll())
                {
                    grid[0, 1] += 3;
                    grid[0, 0] = 41;
                    return true;
                }
                else if (grid[curY, curX - 1] == 0)
                {
                    SetPrev();
                    --curX;
                    grid[prevY, prevX] += 3;
                    grid[curY, curX] = 10;
                }
            }
            return false;
        }
        /// <summary>
        /// Moves the current location up
        /// </summary>
        public bool GoUp()
        {
            if (curY != 0)
            {
                if (dir[curY, curX] == 1 && (grid[curY, curX] / 10 == 4))
                    return false;
                if (dir[curY, curX] == 2 && (grid[curY, curX] / 10 == 1 || grid[curY, curX] / 10 == 3))
                    return false;
                if (curY - 1 == prevY && curX == prevX)
                {
                    RollBack();
                    if (curY == 0 && curX == 0)
                        return false;
                }
                else if (curY - 1 == 0 && curX == 0 && CheckAll())
                {
                    grid[1, 0] += 2;
                    grid[0, 0] = 41;
                    return true;
                }
                else if (grid[curY - 1, curX] == 0)
                {
                    SetPrev();
                    --curY;
                    grid[prevY, prevX] += 2;
                    grid[curY, curX] = 40;
                }
            }
            return false;
        }
        #endregion
        #endregion
        #region Methods
        /// <summary>
        /// If user chooses a direction that is already taken, the cell will roll back
        /// to a previous state
        /// </summary>
        private void RollBack()
        {
            grid[curY, curX] = 0;
            grid[prevY, prevX] = grid[prevY, prevX] / 10 * 10;
            curY = prevY;
            curX = prevX;
            if (curY != 0 || curX != 0)
            {
                if (grid[curY, curX] / 10 == 1)
                {
                    prevY = curY;
                    prevX = curX + 1;
                }
                if (grid[curY, curX] / 10 == 2)
                {
                    prevY = curY - 1;
                    prevX = curX;
                }
                if (grid[curY, curX] / 10 == 3)
                {
                    prevY = curY;
                    prevX = curX - 1;
                }
                if (grid[curY, curX] / 10 == 4)
                {
                    prevY = curY + 1;
                    prevX = curX;
                }
            }
            grid[0, 0] = 41;
        }
        /// <summary>
        /// Sets the previous coordinates
        /// </summary>
        private void SetPrev()
        {
            prevY = curY;
            prevX = curX;
        }
        #endregion
    }
}
