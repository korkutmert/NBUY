'use strict'
let sonuc;
let  gorevListesi=[
    {'id': 1, 'gorevAdi':'Görev 1'},
    {'id': 2, 'gorevAdi':'Görev 2'},
    {'id': 3, 'gorevAdi':'Görev 3'},
    {'id': 4, 'gorevAdi':'Görev 4'},
];

let ul=document.getElementById('task-list');
// let ul=document.querySelector('#task-list') 

for (const gorev of gorevListesi) {
    let li = 
    `
        <li class="task list-group-item">
        <div class="form-check">
            <input type="checkbox" id="${gorev.id}" class="form-check-input">
            <label for="1" class="form-check"> ${gorev.gorevAdi}</label>
        </div>
</li>
    `;
    ul.insertAdjacentHTML('beforeend', li);
}

// document.querySelector('#task-list').remove();// sildik

// document.querySelector('#task-list').parentElement.remove();
// document.querySelector('#task-list').children[0].remove();// Görev 1' i sildik.


// document.querySelector('#task-list').removeAttribute('class');//içindeki claass ' ı sildik
// document.querySelector('#task-list').children[1].removeAttribute('class');

// sonuc=document.querySelector('#task-list').children[1].getAttribute('class');//sadece ekrana verdik okuduk 
// sonuc=document.querySelector('#task-list').children[1].setAttribute('class','bg-danger');//Class ın eski özelliklerini kaldırıd bg-danger yaptı.(değiştirme işlemi)

sonuc=document.querySelector('#task-list').children[1].classList;
document.querySelector('#task-list').children[1].classList.add('bg-danger');//Eski haline devam ederken bg-danger ekledik. (ekleme işlemi)
sonuc=document.querySelector('#task-list').children[1].classList.contains('bg-danger')//1. children bg-danger içeriyor mu ?


console.log(sonuc);