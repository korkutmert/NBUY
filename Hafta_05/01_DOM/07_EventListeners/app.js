'use strict'
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

let btnEkle= document.querySelector('#btnAddNewTask')
btnEkle.addEventListener('click',function(event){
//btn ekle adlı elemte tıklandığı zamaan çalışacak kodlar burada.
// buraya gelen event parametresi ilgili elementin gerçeklesen click olayı ile ilgili bilgileri barındırıyor
// event.preventDefault();//sayfanın yenilenmesini önledi default olarak.
// console.log('btnEkle tıkladnı');
});


// let btnTemizle = document.querySelector('#btnClear');
// btnTemizle=addEventListener('click',clearAll)//clearAll ' a () koymadık çünkü eventlistener bana sadece adını syöle click olunca ne yapcaksam onun adını söyle diyor. () koyarsak onu çalıştırmaya çalışmış oluruz.

// function clearAll(event){
// event.preventDefault();
// console.log('tıkladnı');
// };

let btnAdd = document.querySelector('#btnAddNewTask')
btnAdd.addEventListener('click',newTask)

function newTask (event){
    event.preventDefault();
    event.target.classList.add('btn-warning');
    
    console.log(event.target);
    

};