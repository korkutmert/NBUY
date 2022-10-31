let sonuc;

//getElementById

sonuc=document.getElementById('title');
sonuc=document.getElementById('title').id;
sonuc=document.getElementById('title').className;
sonuc=document.getElementById('title').classList;

document.getElementById('title').style.fontSize='50px';
document.getElementById('title').style.color='red';


//---------------------------------------------------------------------

//-querySelector

sonuc=document.querySelector('#title')
sonuc=document.querySelector('div')
sonuc=document.querySelector('.h1')

sonuc=document.querySelector('li:last-child');//sonuncuyu seçer, first birinciyi seçer
sonuc=document.querySelector('li:nth-child(2)')//istediğimizi seçtiriyoruz.






// MULTİPLY SELECT------
//getElementsByClassName

sonuc=document.getElementsByClassName('task-list')// id olduğu içib boş verir.
sonuc=document.getElementsByClassName('task')
sonuc=document.getElementsByClassName('task')[0].innerText;
sonuc=document.getElementsByClassName('task')[2].innerText;

sonuc=document.getElementsByClassName('task')
// for (let i = 0; i < sonuc.length; i++) {
    
//     console.log(sonuc[i].innerText);// DÖngüyle içindeki elemanları yazdırdık.
// }


let taskList = document.getElementsByClassName('task');

// for (const task of taskList) ;
// {
//     task.style.color=('red');
//     task.style.fontSize=('30px');
//     task.innerText='item'; //içindeki her elemana 'item' yazdık.
// } 

let taskList2 = document.getElementById('task-list-2');// Geriye tek bir değer döndürür. Yukarıdan aşağı ilk karşılaştığını döndürür.

// sonuc=taskList2.getElementsByClassName('task');
sonuc=taskList2.getElementsByTagName('li');// Birden çok değer döndürür.


taskList2=document.querySelectorAll('#task-list-2 li')//(ALL ) hepsini alır.. YANi burda ==> taskList-2'nin içindeki li leri aldı.Birden çok değer döndürür.


for (const task of sonuc)
{
    task.style.backgroundColor='navy'
    task.style.color='white'    
}

console.log(sonuc);




//