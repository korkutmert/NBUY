let sonuc;

sonuc = Number('10.6');
sonuc = parseInt('10,6');//  sonuc =10 tam sayı olan kısmını alır.
sonuc =parseInt('10.6dsad');// sonuc =10
sonuc =parseInt('sadasd10.6dsad');// sonuc =NaN
sonuc = parseFloat('10.6asdsa');//Sonuc = 10.6 Virgülden sonra sayılar bitene kadar alır.

let sayi = 15.468756;
sonuc = sayi.toFixed(4);//Virgülden sonra parantezdeki rakam kadar yazar ve yuvarlar
sonuc = sayi.toPrecision(4);//Virgülden sonra 2 basamak yazar (onar onar)

sonuc=Math.round(2.4);//Otomatik yuvarlama işlemi yapar.
sonuc=Math.round(2.5);
sonuc=Math.ceil(2.4); // sonuc=3 ne olursa olsun üste yuvarlar
sonuc=Math.floor(2.4);// sonuc= 2 ne olursa olsun en aşağı yuvarlar
sonuc=Math.pow(2,3);//üs alma . İkinin 3 . kuvvetini aldık.
sonuc=Math.sqrt(25);//karekök alma
sonuc=Math.abs(-7);//mutlak değer alma
sonuc=Math.min(43,56,7,4,104);//en küçük sayıyı bulur.
sonuc=Math.max(58,102,1,4,78);//en büyük sayıyı bulur.
sonuc=Math.random();// 0-1 arası random sayı üretme
sonuc=parseInt(Math.random()*10);//0-10 arası sayı uretme 10 dahil değil 0 dahildir.






console.log(sonuc, typeof sonuc);