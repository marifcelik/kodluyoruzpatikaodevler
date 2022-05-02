const yarıcap = process.argv[2];

function alan(r) {
    const sonuc = Math.PI * (r ** 2);
    console.log(`Yarıçapı ${r} olan dairenin alanı: ${sonuc} şeklindedir`);
}

alan(yarıcap);