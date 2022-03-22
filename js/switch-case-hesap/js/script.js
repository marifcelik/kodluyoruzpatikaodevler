/* const text = document.getElementById('text')

const stilDegis = () => {
    text.style.color = 'red'
    text.style.fontSize = '18px'
    text.style.fontFamily = 'Ubuntu'
} */

/* function istek() {
    let kelime = prompt("Kelime giriniz")
    console.log(kelime)
}
 */

/* const karakter = document.getElementById('heisenberg')
const slut = document.getElementsByClassName('stupid-bitch')
const classes = document.getElementsByClassName('alternate')
const liste = document.querySelector('ul')

let deneme = slut[0].textContent += ' (ruined everything)'

for (let i = 0; i < classes.length; i++) {
    classes[i].style.color = 'red';
}

var input = document.getElementById('veri')
var ekle = document.getElementById('ekle')

ekle.addEventListener("click", () => {
    var li = document.createElement('li')
    li.textContent = input.value
    liste.appendChild(li)
    input.value = ""
}) */


document.querySelector('button').addEventListener("click", () => {
    let deger = document.querySelector('input').value;
    let islem = deger.indexOf('+') + 1 ? '+' : deger.indexOf('-') + 1 ? '-' : deger.indexOf('*') + 1 ? '*' : '/'
    switch (islem) {
        case '+':
            let artı = deger.indexOf('+')
            console.log(parseInt(deger.substring(0, artı)) + parseInt(deger.substring(artı + 1, deger.length)));
            break;
        case '-':
            let eksi = deger.indexOf('-')
            console.log(parseInt(deger.substring(0, eksi)) - parseInt(deger.substring(eksi + 1, deger.length)));
            break;
        case '*':
            let carpi = deger.indexOf('*')
            console.log(parseInt(deger.substring(0, carpi)) * parseInt(deger.substring(carpi + 1, deger.length)));
            break;
        case '/':
            let bolu = deger.indexOf('/')
            console.log(parseInt(deger.substring(0, bolu)) / parseInt(deger.substring(bolu + 1, deger.length)));
            break;
        default:
            break;
    }
})
