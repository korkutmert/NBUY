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

console.log(sonuc);