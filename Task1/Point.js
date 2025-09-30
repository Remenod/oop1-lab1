class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    calculateDistance(other) {
        const dx = this.x - other.x;
        const dy = this.y - other.y;
        return Math.sqrt(dx * dx + dy * dy);
    }

    toString() {
        return `(${this.x}, ${this.y})`;
    }
}