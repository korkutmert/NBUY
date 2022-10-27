// function selamVer(){

//     console.log('merhaba js');
// }
// selamVer(); // içerdeki kodların çalışması için bunuçağırmamız gerekli.Fonksiyonun üstüne yazılsada çalışır.

//-----------------------------------------------------------------------------------

// function selamVer(isim=''/*Varsayılan olarak, default değerini boş  yani : '' verdik.*/)
// {
//     console.log('merhaba ' + isim);
// }
// selamVer('mert') 

//-----------------------------------------------------------------------------------

// function yasHesapla(dogumYili)
// {
//   return new Date().getFullYear()- dogumYili;
// }

// console.log(yasHesapla(1999));

// let yas= yasHesapla(1999);

// if (yas < 30) 
//     {
//     console.log('uygun değilsiniz.');    
//     } 
// else 
//     {
//         console.log('girebilrisiniz');
//     }


//-----------------------------------------------------------------------------------

/* Bit tutar bilgisi alıp, bu tutarın kdvsini hesaplayıp geri döndüren function*/

// function kdvHesapla(tutar){
//     let sonuc=(tutar * 0.18).toFixed(2)
//     return sonuc;
// }

// console.log(kdvHesapla(100)/* TL*/);
// console.log(kdvHesapla(250)/* TL*/);


//-----------------------------------------------------------------------------------


// function kdvHesapla(){
//     for (let i = 0; i < arguments.length; i++) {
        
//         console.log(arguments[i] * 0.18)
        
//     }
    
// }
// kdvHesapla(100,200,300)

//-----------------------------------------------------------------------------------

/*Kendisine gödnerilecek tutar bilgilerini kullanarak kdv'leri hesaplayıp, geriye hesaplanmış kdvleri içinde barındıran bir dizi döndüren function */

function kdvHesapla() 
{
    let sonuc =[];
    for (let i = 0; i < arguments.length; i++) {
        
        kdv=(arguments[i] * 0.18);
        kdv=kdv.toFixed(2);
        sonuc[i]=kdv;
    }
    return sonuc;
}
console.log(kdvHesapla(100,450,800));