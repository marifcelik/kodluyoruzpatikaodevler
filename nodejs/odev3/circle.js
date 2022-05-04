function area(r) {
    return Math.PI * (r ** 2);
}

function circumference(r) {
    return 2 * Math.PI * r;
}

module.exports = { area, circumference }