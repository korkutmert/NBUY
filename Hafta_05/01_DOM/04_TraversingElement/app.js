let sonuc;
// let taskList = document.getElementById('task-list')
// sonuc=taskList.children;//içindeki tüm elemanalrı ver 3 adet li verdi
// sonuc=taskList.children[0];//içindeki 3 adet li'den 0. indexteki li'yi verdi
// sonuc=taskList.firstElementChild.innerText//Görev 1 yazdı
// sonuc=taskList.lastElementChild.innerText//görev 3 yazdı

// sonuc=document.getElementById('title')
// sonuc = sonuc.parentElement;//Bir üst ebevyn elemente çıkmasını sağplar.

// taskList=document.querySelector('.task')
// sonuc=taskList.nextElementSibling.innerText;//kendisiyle aynı seviyede olan bir sonraki elementi seçer yani burda Görev 2 yi seçti. Previous ise öncekine gider.



let ul = document.getElementById('task-list')
sonuc=ul.children;
sonuc=ul.children[0].children[0].children[0].checked=true;//görev 1 i işaretlemiş olduk.

console.log(sonuc);




//