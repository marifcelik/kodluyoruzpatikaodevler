setInterval(() => {
    let date = new Date();
    let saat = date.getHours(),
        dakika = date.getMinutes(),
        saniye = date.getSeconds()

    document.querySelector('.hour').textContent = saat;
    dakika < 10 ? document.querySelector('.minute').textContent = '0' + dakika : document.querySelector('.minute').textContent = dakika;
    saniye < 10 ? document.querySelector('.second').textContent = '0' + saniye : document.querySelector('.second').textContent = saniye;
}, 1000)

let ad = prompt('adınız ?')
if (!ad)
    ad = 'anonim'
document.querySelector('h1').textContent = `merhaba ${ad[0].toLocaleUpperCase() + ad.slice(1, ad.length).toLocaleLowerCase()}, hoşgeldin.`

