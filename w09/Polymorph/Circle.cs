class Circle : Shape
{
    private double radius;
    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area,2);
    }
}