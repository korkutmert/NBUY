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
            <li class="task list-group-item ">
            <div class="form-check ">
                <input type="checkbox" id="${gorev.id}" class="form-check-input ">
                <label for="1" class="form-check">${gorev.gorevAdi}</label>
                
            </div>
            <div class="dropdown ">
  <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
  <i class="fa-solid fa-ellipsis"></i>
  </button>
  <ul class="dropdown-menu ">
    <li><a onclick="removeTask(${gorev.id})" class="dropdown-item" href="#"><i class="fa-solid fa-trash-can"></i> Sil</a></li>
    <li><a class="dropdown-item" href="#"><i class="fa-solid fa-pen"></i> Düzenle</a></li>
    
  </ul>
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

function ilkHarfiBuyut(value) {

    let ilkHarf=txtTaskName.value[0].toUpperCase();
    let geriKalan=txtTaskName.value.slice(1);
    return ilkHarf + geriKalan;

}
function removeTask(id){

        let deleteId;

        // for (const gorevIndex in gorevListesi) {
            
        //         if (gorevListesi[gorevIndex].id==id) {

        //             deletedId=gorevIndex;
        //         }
        //     }


        // delectedId=gorevListesi.findIndex(function(gorev){return gorev.id==id;})

        delectedId=gorevListesi.findIndex(gorev => gorev.id==id)
            //Görev listesi dizisinden kaçıncı sıradaki elemanın silineceğini biliyoruz.deleteId'nci sıradaki elemanı sileceğiz
            gorevListesi.splice(delectedId,1);
displayTasks()

}

displayTasks()
