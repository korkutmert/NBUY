/*
Değişkenler tanımlanırken 3 farklı keyword kullanılabilir.

1)var
2)let
3)const(sabit)

-ES6 ile birlikte artık Modern Javascript tabiri kullanılmaya başlanmıştır. Bu süreçte let ve const kullanılır var kullanmaktan kaçının.

-JS'te değişken tanımlarken tip belirtilmez.
-Bu , değişkenlerin tipi olmadığı anlamına gelmez.
-JS motoru bir dedğişkene değer atanması esnasında o değere göre tipi belirler.
-Eğer henüz bir değişkene değer atanmamışsa undefined olarak kabul edilir.

*/
// let yas = 20;
// console.log(yas)

// let ad = 'Geç kalan Sema'
// let soyad = 'Geç kalan Harun'
// console.log(ad);
// console.log(soyad);
// console.log(ad,soyad);

// let firstName =' Mert '
// let lastName = 'Muslu'
// console.log(firstName + '' + lastName);


// let sayi1 ='15' 
// let sayi2 ='25'
// let sayi3 ='45'


// let s1=15, s2=25, s4=45;

// let say1=25,
//     say2=15,
//     say3=45;

// let durum = true;

// sayi1=125;
// console.log(sayi1);

// let toplam=0;
// toplam = toplam + say1;

// const benimDogumYilim = 1999;
// console.log( ' Benim Doğum yılım :' + '' + benimDogumYilim);

/* 
- Bildiğiniz değişken isimlendirme yöntemlerini burdada kullanabiliriz
-Değişkenleri genellikle camelCase ile isimlendiririz.
-Değişken isminde harf, rakam, $ ve _ olabilir.
-Değişken ismi rakamla başlamaz.
- Reserved keywordler değişken adı olarak kullanılmaz.


-Const sabit değerleri tutmak için kullanılır. Genellikle tamamen büyük harf ile isimlendirilir.
*/

// const PI_SAYISI = 3.14;
// const _PI_SAYISI = 3.14;
// const RENK_1 = 'Sarı'
// const RENK_2 = 'Siyah'
// let renk_3 = 'yeşil';
// console.log(RENK_1,RENK_2,renk_3);

/*-------------------------------DATA TYPES----------------------------------------*/


//1-) NUMBER 

// infinity ve NaN JS'ye özel sayılardır. 0 a bölme gibi sonuçsuz işlemler  vb işlmeler için üretilmiştir. 
// let sayi1 = 100;
// console.log(sayi1);
// console.log(typeof sayi1);
// console.log(typeof (sayi1));

// let sayi2 = 17.5;
// console.log( sayi2, typeof sayi2); 

// let sayi3= 25/0;
// console.log(sayi3, typeof sayi3);

// let sayi4 ='okul' / 25;
// console.log(sayi4, typeof sayi4);


// let sayi5 = 99999999999999995999999999999999464512451215451255125215457912365897456546451245121545125512521545791236589745654645124512154512551252154579123658974565464512451215451255125215457912365897456n;

// console.log(sayi5, typeof sayi5 );

// let sayi6= sayi5 * 99999999999999999999999999999999999999999999999999999999999n;
// console.log(sayi6,typeof sayi6);

//STRING

/*
-JS'de string ifadeler üç farklı şekilde ifade edilir.
1) Tek tırnak ile ('')
2) Çift tırnak ile ("")
3) Backticks (``) 

*/
   
// let ad = '"mert"';
// let soyad = "'Muslu'";
// let adSoyad= ad + " " + soyad;
// console.log(adSoyad);
//  Tek tırnak kullandıysak içie de tek tırnak koymak istiyosak \ kaçış operatörü ile benden sonra gelecek olan kendi gerçek işini yapmasın diyebiliriz.

//  let adres = 'Halitağa Mah. \nSütlü Nuriye Sokak. \nCandaş Apartmanı No:21 \n \tBeşiktaş';
//  console.log(adres);

// let adSoyad = ' Mert Korkut Muslu';
// let yas = '23';
// let kanGrubu = ' BRh+';
// let kilo = '75';
// let cinsiyet = 'Erkek';
// console.log('Sayın' + adSoyad + ',' + yas + ' yaşındasınız.'+'\nKilo : ' + kilo + '\nKan Gubu : ' + kanGrubu + '\nCinsiyet : '+ cinsiyet );

// console.log(`Sayın ${adSoyad}, ${yas} yaşındasınız.
// Kilo : ${kilo}
// Kan Grubu : ${kanGrubu}
// Cinsiyet : ${cinsiyet}
// `)

//---------------------BOOLEAN----------------------------------------

// let durum =true;
// console.log(durum);
// console.log(durum , typeof durum);

// let ad = 'mert'
// console.log(ad , typeof ad);

// -----NULL-UNDEFİNED-------

// let yas ;
// console.log(yas); // Değer vermedik bunun için undefined verdi. Değeri olmadığı için tip belirleyemedi bu sebepten dolayı undefined.

// yas=null; // Null'un tipi object olarak belirlenmiştir. İNfinity ise numberdır.
// yas=12/0;
// console.log(yas , typeof yas);

// JS'DE CHAR DİYE BİR TİP YOKTUR.

//----------------------------CONVERT DATA TYPES-------------------------------------

// let durum =false;
// console.log(true , typeof durum);

// let metin = 'Durumunuz ' + durum + ' şeklindedir.'
// console.log(metin , typeof metin);   // boolean ve string birleince sonuc string olur

// let durumMetin = String(durum); // boolean olanı stringe cevirdi
// console.log(durumMetin , typeof durumMetin);

// let sayi ='23';
// let metin2 = sayi + 'yaşındasınız.'
// console.log(metin2 , typeof metin2); // number ve string birleşince sonuc string olur

// let sayiMetin = String(sayi);//number'ı stringe cevirdi.
// console.log(sayi, typeof sayiMetin);

// let metinSayi ='455';
// console.log(metinSayi, typeof metinSayi);
// let metinSayiNumber = Number(metinSayi);// stringi number'a cevirdi.
// console.log(metinSayiNumber, typeof metinSayiNumber);


// let sayiMetin ='          145           '
// console.log(sayiMetin  , typeof sayiMetin);
// let sayi = Number(sayiMetin);
// console.log(sayi, typeof sayi); // boşlukları kaldırıp number'a cevirdi.

// let sayi = 1453n;
// console.log(sayi,typeof sayi); // Sonunda n varsa  tipi 'bigint', olur number olmaz. 

// console.log(Number(true));// 1 olarak dönüştürür.
// console.log(Number(false));// 0 olarak dönüştürür.

// console.log(Boolean(0));// False olarak dönüştürür.
// console.log(Boolean(1));// True olarak dönüştürür.
// console.log(Boolean('dsad'));// Bu da true olarak verir. Çünkü sadece 0-1 e ister içine.

//---ALIŞTIRMALAR (GOOGLE CONSOLDAN İNCELE)-------
let a ;
a = '' + 1 + 0; console.log(a, typeof a);
a = '' - 1 + 0; console.log(a, typeof a);
a = true + false; console.log(a, typeof a);
a = 6 / '3';      console.log(a, typeof a);
a = 4 + 5 +'px' ; console.log(a, typeof a);
a = '$' + 4 + 5; console.log(a, typeof a);
a = '4px' - 2; console.log(a, typeof a);
a = '          9             ' + 5; console.log(a, typeof a);
a = null + 1; console.log(a, typeof a);
a = undefined +1 ; console.log(a, typeof a);

