using System;
using System.Numerics;
using System.Collections.Generic;

namespace Lab.Task2;

class TSphere : TCircle
{
    public TSphere Clone(TSphere c) => new TSphere(c.radius);
    
    public TSphere() : base(){}
    public TSphere(double radius) : base(radius){}

    public override double GetArea() => 4 * Math.PI * radius * radius;
    public override double GetSectorArea(double angle) => (4 * Math.PI * radius * radius) * ((angle % 360) / 360.0);
    public double GetVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

    public override bool Equals(object obj) => obj is TSphere other && this.radius == other.radius;
    public override int GetHashCode() => radius.GetHashCode();
    public new object Clone() => new TSphere(radius);
    
    public static bool operator ==(TSphere a, TSphere b) => a.radius == b.radius;
    public static bool operator !=(TSphere a, TSphere b) => a.radius != b.radius;
    public static bool operator >(TSphere a, TSphere b) => a.radius > b.radius;
    public static bool operator <(TSphere a, TSphere b) => a.radius < b.radius;
    public static bool operator <=(TSphere a, TSphere b) => a.radius <= b.radius;
    public static bool operator >=(TSphere a, TSphere b) => a.radius >= b.radius;

    public static TSphere operator +(TSphere a, TSphere b) => new TSphere(Math.Abs(a.radius + b.radius));
    public static TSphere operator +(double a, TSphere b) => new TSphere(Math.Abs(a + b.radius));
    public static TSphere operator +(TSphere a, double b) => new TSphere(Math.Abs(a.radius + b));
    public static TSphere operator -(TSphere a, TSphere b) => new TSphere(Math.Abs(a.radius - b.radius));
    public static TSphere operator -(double a, TSphere b) => new TSphere(Math.Abs(a - b.radius));
    public static TSphere operator -(TSphere a, double b) => new TSphere(Math.Abs(a.radius - b));
    public static TSphere operator *(TSphere a, TSphere b) => new TSphere(Math.Abs(a.radius * b.radius));
    public static TSphere operator *(double a, TSphere b) => new TSphere(Math.Abs(a * b.radius));
    public static TSphere operator *(TSphere a, double b) => new TSphere(Math.Abs(a.radius * b));
    public static TSphere operator /(TSphere a, TSphere b) => new TSphere(Math.Abs(a.radius / b.radius));
    public static TSphere operator /(double a, TSphere b) => new TSphere(Math.Abs(a / b.radius));
    public static TSphere operator /(TSphere a, double b) => new TSphere(Math.Abs(a.radius / b));
}