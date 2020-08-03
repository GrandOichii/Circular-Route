namespace CRLib
{
    public class CRPoint
    {
        #region Values
        readonly private int y;
        readonly private int x;
        readonly private int state;
        public int Y { get => y; }
        public int X { get => x; }
        public int State { get => state; }
        #endregion
        #region Constructors
        public CRPoint(int y, int x, int state)
        {
            this.x = x;
            this.y = y;
            this.state = state;
        }
        #endregion
    }
}
