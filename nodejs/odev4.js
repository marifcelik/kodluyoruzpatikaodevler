const fs = require('fs');

let data = { "name": "Employee 1 Name", "salary": 2000 }

fs.writeFileSync('employees.json', JSON.stringify(data));
console.log('dosya oluşturuldu');

let icerik = fs.readFileSync('./employees.json', 'utf-8');
console.log(icerik);

fs.appendFileSync('./employees.json', '\nsonradan eklenmiş yazı', 'utf-8');
console.log(`dosya güncellendi. yeni hali : \n${fs.readFileSync('./employees.json', 'utf-8')}`);

fs.unlinkSync('./employees.json');
console.log('dosya silindi.');