namespace TestShape
{
    public abstract class Shape
    {
        public double Area { get; protected set; }
        public delegate double CalculateArea();
        public Shape(CalculateArea formula)
        {
            Area = formula();
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double r) : base(delegate (){return Math.PI * r * r;})
        {
            Radius = r;
        }
    }
    public class Triangle : Shape
    {
        public double A { get;private set; }
        public double B { get;private set; }
        public double C { get;private set; }
        public bool IsIsosceles { get; private set; }
        public Triangle(double a, double b, double c) : base(delegate () {var p = (a + b + c) / 2;
                                                                            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));})
        {
            A = a;
            B = b;
            C = c;
            var sides = new List<double>()
            {
                a,
                b,
                c,
            };
            var minSide = sides.Min();
            sides.Remove(minSide);            
            IsIsosceles = Math.Abs(sides.ElementAt(0) - sides.ElementAt(1)) < float.Epsilon;
        }
    }
}