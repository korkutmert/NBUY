'use strict';
let  notEkleButon= document.getElementById('notEkle');
let not = document.getElementById('notYaz');

notEkleButon.addEventListener('click', yeniNot);
txtTaskName.addEventListener('keypress', function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

let notList = [
    {'id': 1, 'notGiris':'not 1'},
    {'id': 2, 'notGiris':'not 2'},
    {'id': 3, 'notGiris':'not 3'},
    {'id': 4, 'notGiris':'not 4'},
];

function notTaskBar() {
    let ul = document.getElementById('notListe');
    ul.innerHTML='';
    for (const not of notList) {
        let li = `
        <li class="notListe">
        
            <label for="1" class="listIndex"> ${not.notGiris}</label>
            <button class="checkButton"><i class="fa-regular fa-square-check"></i></button>
            <button class="trashButton"><i class="fa-regular fa-trash-can"></i></button>
        </li>
    `;
        
    }
}

function yeniNot(event){
    event.preventDefault();
    if (isFull(not.value)) {
        notList.push(
            {
                'id': notList.length + 1,
                'notAdi': (not.value) 
            }
        );
        notTaskBar();
    }else{
        alert('Not giriniz.!');
    }
    not.value='';
    not.focus();
};
function isFull(value){
    if (value.trim()=='') {
        return false;
    }
    return true;
};
notTaskBar();



