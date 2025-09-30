class TSphere extends TCircle {
    constructor(radius, name = "TSphere") { super(radius, name); }
    getArea() { return 4 * Math.PI * this.getRadius() * this.getRadius(); }
    getSectorArea(angle) {
        const norm = angle % 360;
        const factor = norm === 0 ? 1 : norm / 360;
        return this.getArea() * factor;
    }
    getVolume() { return (4 / 3) * Math.PI * Math.pow(this.getRadius(), 3); }
    toString() { return `Sphere "${this.name}"(r=${this.getRadius()})`; }
}