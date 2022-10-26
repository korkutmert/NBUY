let ders ='Bahçeşehir Üniversitesi Wissen Akademie İstanbul';
let sonuc;
sonuc = ders.toLowerCase();//küçüğe çevirdi
sonuc= ders.toLocaleLowerCase();//Harfi harfine (Türkçe karakter)küçültür
sonuc= ders.toUpperCase();//Büyüğe çevirir
sonuc= ders.toLocaleUpperCase();//Harfi Harfine (Türkçe karakter) çevirir


sonuc = ders.length;//uzunluğunu verir
sonuc =ders[0];//0.indeksdeki harfi verir.
sonuc =ders[10];
sonuc =ders[45];

sonuc = ders.slice(0,16); //0-16 arasındaki ifadeyi al
sonuc = ders.slice(10)//10'dan başla sonuna kadar al.

sonuc=ders.substring(20,5);// 20'den 5 'e kadar alır. 5-20 nin görevini görür.
sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);

sonuc = ders.replace('Akademie', 'Eğitimi');// birinci yazılanı iknici yazılanla değiştirir.
sonuc = ders.replace(' ','-')//Soldan sağa çalışırken ilk gördüğüne uygular.(Boşluğu - 'ye çevirir.)


sonuc = ders.trim();//Bşataki ve sondaki fazla boşlukları kaldrıır.
sonuc =ders.trimStart();// SAdece baştakini kaldırır
sonuc =ders.trimEnd();// SAdece sondakini kaldırır.

sonuc = ders.toLocaleUpperCase().indexOf('ü');

sonuc = ders.split(' '); // parçalara ayırıp dizi yapar

//-----------------------------------------------------------
// Kullanıcnın girdiği bir cümlenin kaç sözcükten oluştuğunu bulunuz.


// let cumle= prompt('Metni Giriniz.'); // 

// let sozcukDizisi;

// sozcukDizisi=cumle.split(' ');
// console.log(sozcukDizisi.length);

//-----------------------------------------

sonuc =ders.includes('Akademie');//içerisinde geçip geçmediğine bakar
sonuc = ders.startsWith('B');// bununla mı başlıyor diye bakar
sonuc = ders.endsWith('istanbul');//bununla mı bitiyor diye bakar.


console.log(sonuc);