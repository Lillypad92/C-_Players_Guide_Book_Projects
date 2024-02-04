namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.ThePoint
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Point() 
        { 
            X = 0; 
            Y = 0;

        }
        public void DisplayPoint(Point p) 
        {

            Console.WriteLine($"({p.X}, {p.Y})");
        }
        public void RunPoint()
        {
            DisplayPoint(new Point(2, 3));
            DisplayPoint(new Point(-4, 0));
        }

    }
    
}
