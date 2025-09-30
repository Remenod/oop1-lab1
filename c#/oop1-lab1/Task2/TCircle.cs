using System;
using System.Numerics;
using System.Collections.Generic;

namespace Lab.Task2;

class TCircle : ICloneable
{
    private double _r;
    public double radius
    {
        get => _r;
        set => _r = value < 0 ? throw new ArgumentException("Negative radius...") : value;
    }
    public TCircle(){}
    public TCircle(double r) => radius = r;

    public object Clone() => new TCircle(radius);
    public override bool Equals(object obj) => obj is TCircle other && this.radius == other.radius;
    public override int GetHashCode() => radius.GetHashCode();
    public override string ToString() => radius.ToString();

    public virtual double GetArea() => Math.PI * radius * radius;
    public virtual double GetSectorArea(double angle) => (Math.PI * radius * radius) * ((angle%360)/360.0);
    public virtual double GetCircleLength() => Math.PI * 2 * radius;

    public static bool operator ==(TCircle a, TCircle b) => a.radius == b.radius;
    public static bool operator !=(TCircle a, TCircle b) => a.radius != b.radius;
    public static bool operator >(TCircle a, TCircle b) => a.radius > b.radius;
    public static bool operator <(TCircle a, TCircle b) => a.radius < b.radius;
    public static bool operator <=(TCircle a, TCircle b) => a.radius <= b.radius;
    public static bool operator >=(TCircle a, TCircle b) => a.radius >= b.radius;

    public static TCircle operator +(TCircle a, TCircle b) => new TCircle(Math.Abs(a.radius + b.radius));
    public static TCircle operator +(double a, TCircle b) => new TCircle(Math.Abs(a + b.radius));
    public static TCircle operator +(TCircle a, double b) => new TCircle(Math.Abs(a.radius + b));

    public static TCircle operator -(TCircle a, TCircle b) => new TCircle(Math.Abs(a.radius - b.radius));
    public static TCircle operator -(double a, TCircle b) => new TCircle(Math.Abs(a - b.radius));
    public static TCircle operator -(TCircle a, double b) => new TCircle(Math.Abs(a.radius - b));

    public static TCircle operator *(TCircle a, TCircle b) => new TCircle(Math.Abs(a.radius * b.radius));
    public static TCircle operator *(double a, TCircle b) => new TCircle(Math.Abs(a * b.radius));
    public static TCircle operator *(TCircle a, double b) => new TCircle(Math.Abs(a.radius * b));

    public static TCircle operator /(TCircle a, TCircle b) => new TCircle(Math.Abs(a.radius / b.radius));
    public static TCircle operator /(double a, TCircle b) => new TCircle(Math.Abs(a / b.radius));
    public static TCircle operator /(TCircle a, double b) => new TCircle(Math.Abs(a.radius / b));
}
