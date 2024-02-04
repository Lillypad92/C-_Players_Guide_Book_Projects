namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.TheColor
{

    public class TheColor
    {

        
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public TheColor(byte r, byte g, byte b) 
        { 
            R = r; 
            G = g; 
            B = b;
        }

        public TheColor()
        {
        }

        public static TheColor White { get; } = new TheColor(255, 255, 255);
        public static TheColor Black { get; } = new TheColor(0, 0, 0);
        public static TheColor Red { get; } = new TheColor(255, 0, 0);
        public static TheColor Orange { get; } = new TheColor(255, 165, 0);
        public static TheColor Yellow { get; } = new TheColor(255, 255, 255);
        public static TheColor Green { get; } = new TheColor(0, 128, 0);
        public static TheColor Blue { get; } = new TheColor(0, 0, 255);
        public static TheColor Purple { get; } = new TheColor(128, 255, 128);

        public void Run() 
        {

            TheColor c1 = TheColor.White;
            TheColor c2 = new TheColor(42, 42, 42);
            Console.WriteLine($"({c1.R}, {c1.G}, {c1.B})");
            Console.WriteLine($"({c2.R}, {c2.G}, {c2.B})");
        }
        
    }
}
