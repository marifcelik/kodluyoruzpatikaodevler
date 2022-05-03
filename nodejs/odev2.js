let posts = [
    {
        id: 1,
        title: 'yapılacak çalışmalar'
    },
    {
        id: 2,
        title: 'izlenecek film ve diziler'
    },
    {
        id: 3,
        title: 'okunacak kitaplar'
    }
];

function listele(obje) {
    return new Promise((resolve, reject) => {
        if (obje)
            resolve(obje);
        else
            reject('hata');
    })
}

function ekle(veri) {
    return new Promise((resolve, reject) => {
        try {
            posts.push(veri);
            resolve('eklendi');
        }
        catch (err) {
            reject(err);
        }
    })
}

async function ekleVeListele(veri) {
    await listele(posts)
        .then(res => console.log(res));
    await ekle(veri)
        .then(res => console.log(res));
    await listele(posts)
        .then(res => console.log(res));
    console.log('ve listelendi');
}

ekleVeListele({ id: 4, title: 'biraz daha seri ol' });