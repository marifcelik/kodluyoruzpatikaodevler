const circle = require('./circle');
let deger = process.argv[2] || 5
const alan = circle.area(deger);
const cevre = circle.circumference(deger);

console.log(`alan : ${alan}\ncevre : ${cevre}`);