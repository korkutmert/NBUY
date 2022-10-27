// let obje1 ={
//     'urunAd' : 'iPhone 13',
//     'urunfiyat':78000,
//     'urunRenk':'Gri',
//     'onayli':true
// }

// let obje2 ={
//     'urunAd' : 'iPhone 13',
//     'urunfiyat':78000,
//     'urunRenk':'Gri',
    
// }

// if (obje1.onayli==true) {
//     console.log('Bu ürün satışta ');
    
// }
// else {
//     console.log('gelince haber ver ');
// }

// if (obje2.onayli==undefined) {
//     console.log('satıcıyla iletişime geçin');
// }
// else
// {
//     if (obje2.onayli===true) {
//         console.log('bu ürün satışta');
//     } else {
//         console.log('Gelince haber ver ');
//     }
// }
// console.log(obje1);

// console.log(obje1.urunfiyat);
// obje1.urunfiyat=45000;
// console.log(obje1.urunfiyat);
// obje1.urunAdet =15;
// console.log(obje1);


// let ogrenci1 ={
// 'ogrenciNo' : 153,
// 'ogrenciAd' : 'mert',
// 'ogrenciSoyad' : 'muslu',
// 'ogrencYas' : 18,
// 'ogrenciAktif' : true

// }
// ogrenci1.cinsiyet = 'erkek';// burada da eleman eklenebilir.
// if ('cinsiyet' in ogrenci1) {
//     console.log(ogrenci1.cinsiyet);
    
// } else {
//     console.log('Böyle bir özellik tanımlı değil.');
// }


// let kisi1 ={
// 'Ad Soyad' : 'Mert Muslu', // boşluk vb ifadeler olursa dizi gibi tanımlanır aşagıdak clg de yazıyor.
// 'Doğum Tarihi' : '28.10.1999',
// 'kidemYili' : 23, // bu normal tanımlanır arada boşluk yok. Aşagıda clg de var
// }
// console.log(kisi1["Ad Soyad", kisi1.kidemYili]);


// let product1 = { // tırnak olmadan da tanımlanablir.
//     productId : 12,
//     productName : 'samsung',
//     productPrice : 14000
// };

// let product2 = { // tırnak olmadan da tanımlanablir.
//     productId : 13,
//     productName : 'iphone',
//     productPrice : 24000
// };

// let product3 = { // tırnak olmadan da tanımlanablir.
//     productId : 14,
//     productName : 'xiaomi',
//     productPrice : 17000
// };

// let products = [product1, product2, product3];
// console.log(products);


// let products = [ // bir üsttekiyle aynı işlevi yapıyor. bir dizinin içine obje ekliyoruz. {} açılıp yazılan objedir.
//     {id:13, 'name':'iphone',  'price':14000},
//     {id:14, 'name':'samsung', 'price':24000},
//     {id:15, 'name':'xiaomi',  'price':18000},

// ];
// console.log(products);
// console.log(products[2].name + '  ' + products[2].price );

let category1 = {};
category1.name = 'Telefon';

let category2 ={};
category2.name= 'bilgisayar';

let categories =[category1,category2];
console.log(categories);