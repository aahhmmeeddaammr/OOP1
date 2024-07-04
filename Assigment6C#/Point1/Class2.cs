namespace Point1
{
    public struct Point
    {
        private int x;
        private int y;
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public  double distance(Point p1)
        {

            int x = this.x;
            int y = this.y;
            double dis = Math.Sqrt( Math.Pow((x - p1.X) ,2) + Math.Pow((y - p1.Y), 2)) ;
            return dis;
        }
    }
}
