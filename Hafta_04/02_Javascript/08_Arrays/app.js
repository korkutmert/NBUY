// let urunler = [];
// urunler[0]='Samsung';
// urunler[1]='ıphone';
// urunler[123]='bilgisayar';  //istediğimiz gibi değer veririz. Baştan dizi eleman sayısnı bildirmek zorunda değiliz.

// let urunler = ['ıphone 13','ıphone XR','dell X5'];
// let fiyatlar= [15000, 325000, 40000] ;
// let renkler=  ['gold', 'gri','black'];

// urunler.forEach((urun, i)=>
// {

//     console.log(urun,fiyatlar[i], renkler[i] );

// })

// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);

// let urun1=[];
// urun1[0]='Iphone 12';
// urun1[1]=25000;
// urun1[2]='Gold';
// urun1[3]=true;

// let urun2=['dell',12000,'black', false];
// let urun3=['Samsung',22400,'red', true];


// let urunler=[urun1, urun2, urun3];




// console.log(urun1);
// console.log(urun2);
// console.log(urun3);
// console.log(urunler);



// let urun1='Iphone 13, 25000, yeşil, true';

// urun1dizi=urun1.split(', ');
// console.log(urun1dizi);


// let ogrenciler =['cemre', 'Melahat' , 'Sema', 'Hasancan'];
// let sonuc;
// sonuc=ogrenciler.length;
// sonuc=ogrenciler;
// sonuc=ogrenciler.toString();
// console.log(sonuc);
// sonuc=ogrenciler.join('-')


// ogrenciler[4]='Serhat';
// ogrenciler.push('Aylin');//dizinin sonuna eleman eklemek için PUSH kullanılır
// ogrenciler.pop();//dizinin sonundan eleman silmek için POP kullanılır.

// sonuc= ogrenciler.push('Aylin');
// sonuc=ogrenciler.pop();//neyi sildiğimizi sonuca aktarıyoruz sonra sonucu ekrana yazdırıyoruz.
// sonuc=ogrenciler.unshift('Aylin');// Dizinin en başına eleman eklemek için kullanılır

// console.log(ogrenciler);
// console.log(sonuc);

let sonuc;
let markalar1 =['mazda', 'toyota', 'mercedes'];
let markalar2 =['opel', 'bmw',];
let markalar3 =['ford',];

console.log('Markalar 1 :' + markalar1);
console.log('Markalar 2 :' + markalar2);
console.log('Markalar 3 :' + markalar3);

sonuc= markalar1.concat(markalar2,markalar3);//iki diziyi birleştirmek için kullanılır.
// sonuc=markalar1.splice(0,1);//0. elemandan başla 1 adet sil uygulandı.
// console.log('Sonuç : ' + sonuc);//ilk hali
// sonuc.splice(0,4)//sonuc dizisinden 0dan başla 4 adet elemanı sil.
console.log('Sonuç : ' + sonuc);// silinmiş hali

//silinenleri başka bir diziye tanımlayarak içinden çekmiş gibi olabilirsin.