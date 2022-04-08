let yapilacaklar = [];
let yapilanlar = [];

const input = document.querySelector('input');
const liste = document.getElementById('liste');
const ekleButon = document.querySelector('button');
const notBox = document.querySelector('.notBox');

window.addEventListener('load', () => {
    if (!localStorage.getItem('yapılacaklar') || !localStorage.getItem('yapılanlar'))
        localSet();
    else
        localGet();
});

input.addEventListener('keyup', (event) => {
    if (event.key === "Enter")
        ekleButon.click();
});

ekleButon.addEventListener('click', () => {
    if (!input.value)
        notBoxShow('boş ekleme yapılamaz');
    else {
        const deger = input.value;
        liEkle(deger);
        yapilacaklar.push(deger);
        localSet();
        input.value = "";
        notBoxShow('eklendi');
    }
});

let control = 0;
document.getElementById('d-all').addEventListener('click', () => {
    liste.childNodes.forEach((eleman) => {
        if (!eleman.classList) // ilk eleman undefined geliyordu
            return;
        if (!eleman.classList.contains('done') && control === 0)
            doneItem(eleman.querySelector('#d-item'));
        else if (eleman.classList.contains('done') && control === 1)
            doneItem(eleman.querySelector('#d-item'));
    });
    if (control === 0) {
        notBoxShow('hepsi yapıldı, bravo !');
        control++;
    }
    else {
        notBoxShow('hepsinden vazgeçildi');
        control = 0;
    }
});

document.getElementById('r-all').addEventListener('click', () => {
    liste.innerHTML = '';
    yapilacaklar = [];
    yapilanlar = [];
    localSet();
    notBoxShow('hepsi silindi');
});

function liEkle(todo, isdoned = '') {
    let li = document.createElement('li');
    if (isdoned) li.classList.add(isdoned);
    li.innerHTML = `<p class="content">
                        ${todo}
                    </p>
                    <div class="icons">
                        <span id="d-item" class="icon">
                            <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#FFFFFF"><path d="M0 0h24v24H0V0z" fill="none"/><path d="M9 16.2L4.8 12l-1.4 1.4L9 19 21 7l-1.4-1.4L9 16.2z"/></svg>
                        </span>
                        <span id="r-item" class="icon"> 
                            <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#FFFFFF"><path d="M0 0h24v24H0V0z" fill="none" opacity=".87"/><path d="M12 2C6.47 2 2 6.47 2 12s4.47 10 10 10 10-4.47 10-10S17.53 2 12 2zm0 18c-4.41 0-8-3.59-8-8s3.59-8 8-8 8 3.59 8 8-3.59 8-8 8zm3.59-13L12 10.59 8.41 7 7 8.41 10.59 12 7 15.59 8.41 17 12 13.41 15.59 17 17 15.59 13.41 12 17 8.41z"/></svg>
                        </span>
                    </div>`;
    const dButton = li.querySelector('#d-item');
    dButton.setAttribute('onclick', 'doneItem(this)');
    const rButton = li.querySelector('#r-item');
    rButton.setAttribute('onclick', 'removeItem(this)');
    liste.appendChild(li);
}

function doneItem(item) {
    const parent = item.parentNode.parentNode;
    let doned = parent.childNodes[0].innerText;

    if (!parent.classList.contains('done')) {
        yapilanlar.push(doned);
        yapilacaklar.splice(yapilacaklar.indexOf(doned), 1);
        parent.classList.add('done');
        notBoxShow('işlem yapıldı');
    }
    else {
        yapilacaklar.push(doned);
        yapilanlar.splice(yapilanlar.indexOf(doned), 1);
        parent.classList.remove('done');
        notBoxShow('vazgeçildi');
    }
    localSet();
}

function removeItem(item) {
    const parent = item.parentNode.parentNode;
    if (parent.classList.contains('done'))
        yapilanlar.splice(yapilanlar.indexOf(parent.childNodes[0].innerText), 1);
    else
        yapilacaklar.splice(yapilacaklar.indexOf(parent.childNodes[0].innerText), 1);
    localSet();
    parent.remove();
    notBoxShow('öğe silindi');
}

function localSet() {
    localStorage.setItem('yapılacaklar', JSON.stringify(yapilacaklar));
    localStorage.setItem('yapılanlar', JSON.stringify(yapilanlar));
}

function localGet() {
    yapilacaklar = [...JSON.parse(localStorage.getItem('yapılacaklar'))];
    yapilanlar = [...JSON.parse(localStorage.getItem('yapılanlar'))];
    listeGuncelle();
}

function listeGuncelle() {
    yapilacaklar.forEach((eleman) => liEkle(eleman));
    yapilanlar.forEach((eleman) => liEkle(eleman, 'done'));     
}

function notBoxShow(text) {
    notBox.innerHTML = `<p>${text}</p>`;
    notBox.style.opacity = 100;
    setTimeout(() => notBox.style.opacity = 0, 1500);
}
