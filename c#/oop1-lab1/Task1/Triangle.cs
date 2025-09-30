using System;

namespace Lab.Task1;

class Triangle
{
    private Point a;
    private Point b;
    private Point c;

    public Point A
    {
        get => a;
        set
        {
            GetSides(value, b, c, out double side_a, out double side_b, out double side_c);
            if(!IsValid(side_a, side_b, side_c)) throw new ArgumentException("Invalid triangle");           
            a = value;
        }
    }

    public Point B
    {
        get => b;
        set
        {
            GetSides(a, value, c, out double side_a, out double side_b, out double side_c);
            if(!IsValid(side_a, side_b, side_c)) throw new ArgumentException("Invalid triangle");           
            b = value;
        }
    }

    public Point C
    {
        get => c;
        set
        {
            GetSides(a, b, value, out double side_a, out double side_b, out double side_c);
            if(!IsValid(side_a, side_b, side_c)) throw new ArgumentException("Invalid triangle");           
            c = value;
        }
    }

    private static bool IsValid(double side_a, double side_b, double side_c)
    {
        if(side_a == 0 || side_b == 0 || side_c == 0) return false;
        if(side_a + side_b < side_c) return false;
        if(side_a + side_c < side_b) return false;
        if(side_c + side_b < side_a) return false;
        return true;
    }
    private static void GetSides(Point a, Point b, Point c, out double side_a, out double side_b, out double side_c)
    {
        side_a = a.CalculateDistance(b);
        side_b = b.CalculateDistance(c);
        side_c = c.CalculateDistance(a);
    }

    public Triangle(Point a, Point b, Point c)
    {
        GetSides(a, b, c, out double side_a, out double side_b, out double side_c);
        if(!IsValid(side_a, side_b, side_c)) throw new ArgumentException("Invalid triangle");        

        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double this[ char index ]
    {
        get => index switch
        {
            'a' => a.CalculateDistance(b),
            'b' => b.CalculateDistance(c),
            'c' => c.CalculateDistance(a),
            _=> throw new IndexOutOfRangeException()
        };
    }

    public double GetPerimeter()
    {
        GetSides(a, b, c, out double side_a, out double side_b, out double side_c);   
        return side_a + side_b + side_c;
    }

    public double GetArea()
    {
        GetSides(a, b, c, out double side_a, out double side_b, out double side_c);
        double s = (side_a + side_b + side_c) / 2;
        return Math.Sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
    }
}