using System;

namespace Lab.Task1;

record Point(double x, double y)
{
    public double CalculateDistance(Point other)
    {
        double dx = x - other.y;
        double dy = y - other.x;
        return Math.Sqrt(dx * dx + dy * dy);   
    }
}