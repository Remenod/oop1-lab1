class TCircle {
    #radius;
    constructor(radius, name = "TCircle") {
        if (radius < 0) throw new Error("Negative radius bro");
        this.#radius = radius;
        this.name = name;
    }
    getRadius() { return this.#radius; }
    setRadius(r) {
        if (r < 0) throw new Error("Negative radius bro");
        this.#radius = r;
    }

    getArea() { return Math.PI * this.getRadius() * this.getRadius(); }
    getSectorArea(angle) {
        const norm = angle % 360;
        const factor = norm === 0 ? 1 : norm / 360;
        return this.getArea() * factor;
    }
    getCircleLength() { return 2 * Math.PI * this.getRadius(); }
    toString() { return `Circle "${this.name}"(r=${this.getRadius()})`; }

    add(other) { return new this.constructor(this.getRadius() + (other.getRadius() ?? other), this.name + "+" + other.name); }
    sub(other) { return new this.constructor(Math.abs(this.getRadius() - (other.getRadius() ?? other)), this.name + "-" + other.name); }
    mul(other) { return new this.constructor(this.getRadius() * (other.getRadius() ?? other), this.name + "*" + other.name); }
    div(other) { return new this.constructor(this.getRadius() / (other.getRadius() ?? other), this.name + "/" + other.name); }

    eq(other) { return this.getRadius() === other.getRadius(); }
    neq(other) { return this.getRadius() !== other.getRadius(); }
    gt(other) { return this.getRadius() > other.getRadius(); }
    lt(other) { return this.getRadius() < other.getRadius(); }
    ge(other) { return this.getRadius() >= other.getRadius(); }
    le(other) { return this.getRadius() <= other.getRadius(); }
}