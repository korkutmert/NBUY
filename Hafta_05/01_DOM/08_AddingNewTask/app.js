'use strict'
let btnAdd= document.getElementById('btnAddNewTask');
btnAdd.addEventListener('click',newTask)

let txtTaskName=document.getElementById('txtTaskName')
btnAdd.addEventListener('keypress',function(event){

    if(event.key=='Enter'){
        event.preventDefault();
        btnAdd.click();
    }
}
)




let  gorevListesi=[
    {'id': 1, 'gorevAdi':'Görev 1'},
    {'id': 2, 'gorevAdi':'Görev 2'},
    {'id': 3, 'gorevAdi':'Görev 3'},
    {'id': 4, 'gorevAdi':'Görev 4'},
];
function displayTasks(){
    let ul=document.getElementById('task-list');
    ul.innerHTML='';//ul nin içindeki boşalt dedik.
    // let ul=document.querySelector('#task-list') 
    
    for (const gorev of gorevListesi) {
        let li = 
        `
            <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="1" class="form-check">${gorev.gorevAdi}</label>
            </div>
    </li>
        `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}



function newTask(event){
    event.preventDefault();
    
    if (isFull(txtTaskName.value)) 
    {
        gorevListesi.push(
            {'id':gorevListesi.length+1,
             'gorevAdi':ilkHarfiBuyut(txtTaskName.value)   
            }
       
            );
    displayTasks();
    } 
    else{
        alert('boş bırkamayınız.')
    }
    txtTaskName.value='';
    txtTaskName.focus();

    
};

function isFull(value){
    if (value.trim()=='') {
        return false;
    }
    return true;
};

function ilkHarfiBuyut(value){

    let ilkHarf=txtTaskName.value[0].toUpperCase();
    let geriKalan=txtTaskName.value.slice(1);
    return ilkHarf + geriKalan;

}
displayTasks()
