class Triangle {
    constructor(a, b, c) {
        this.setPoints(a, b, c);
    }

    setPoints(a, b, c) {
        const [side_a, side_b, side_c] = Triangle.getSides(a, b, c);
        if (!Triangle.isValid(side_a, side_b, side_c)) throw new Error("Invalid triangle");
        this.a = a;
        this.b = b;
        this.c = c;
    }

    static getSides(a, b, c) {
        const side_a = a.calculateDistance(b);
        const side_b = b.calculateDistance(c);
        const side_c = c.calculateDistance(a);
        return [side_a, side_b, side_c];
    }

    static isValid(side_a, side_b, side_c) {
        if (side_a === 0 || side_b === 0 || side_c === 0) return false;
        if (side_a + side_b <= side_c) return false;
        if (side_a + side_c <= side_b) return false;
        if (side_b + side_c <= side_a) return false;
        return true;
    }

    getPerimeter() {
        const [side_a, side_b, side_c] = Triangle.getSides(this.a, this.b, this.c);
        return side_a + side_b + side_c;
    }

    getArea() {
        const [side_a, side_b, side_c] = Triangle.getSides(this.a, this.b, this.c);
        const s = (side_a + side_b + side_c) / 2;
        return Math.sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
    }

    getSide(index) {
        switch (index) {
            case 'a': return this.a.calculateDistance(this.b);
            case 'b': return this.b.calculateDistance(this.c);
            case 'c': return this.c.calculateDistance(this.a);
            default: throw new Error("Invalid side index");
        }
    }

    toString() {
        return `Triangle: A${this.a}, B${this.b}, C${this.c}`;
    }
}