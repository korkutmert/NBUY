//------------------WHİLE---------------

// let i=0;
// while (i<10) {
//     i++;
//     console.log(i + '. Javascript');
    
// }

//----------------DO WHİLE---------------

// let i=0;
// do {
//     console.log(i + '. Java Script');
//     i++;
// } while (i<10);

//----------------FOR------------------

// for (let i = 0; i < 10; i++) {

//     console.log(i + 1 + '.JSs');
    
// }


// ------- 1 *-den 10 a kadar toplam 

// let sonuc= 0;
// for (let i = 1; i <= 10; i++) {

//     console.log(i);
//     sonuc=sonuc+i;  
// }

// console.log( '\nToplam : ' + '' + sonuc);



//--- Kullanıcının girdiği 3 sayıyı toplama----
//  let sonuc= 0;
// for (let i = 1; i <= 3; i++) {
//     let girilen = prompt( i + '.sayıyı giriniz')
//        sonuc = Number(sonuc) + Number(girilen); 
//      }
// alert( '\ntoplam : ' + sonuc);


//---- kullanıcı 0 girene kadar girilen sayıları topylayıp sonucu konsola yazan program

// let girilen;
// let i =1;
// let sonuc =0;
// do {
//     girilen = prompt( i + '.sayıyı giriniz')
//     i++;
//     sonuc=Number(sonuc) + Number(girilen);
    
// } while (girilen!=0);


// console.log(sonuc);

// son örnekteki girilen sayıları da sonuçta yazdıalrım

// let girilensayilar=[];
// let i =0;
// let sonuc =0;

// do {
//     girilensayilar[i] = Number(prompt( i+1 +  '.sayıyı giriniz'))
//     sonuc=Number(sonuc) + Number(girilensayilar[i]);
//     i++;
    
// } while (girilensayilar[i - 1]!=0);
// girilensayilar.pop();
// for (let i = 0; i < girilensayilar.length; i++) {
    
//     console.log(i+1+'.Sayı : ' + girilensayilar[i]);
// }
// console.log(sonuc);

// kullanıcnın istediği kadar sayı girilmesini sağlayın. Sayı girişi bitişi için 0 ' a basılması gereksin.
//0'a basılıp sayi giişi bittiğinde kullanıcıya sorulsun Tek mş ? Çift mi ?
// tek derse tek sayılar ve toplamını 
// çift derse çift sayılar ve toplamını yazdırlaım

// let i=0;
// let sayilar = [];

// do {
//     sayilar[i]=Number(prompt(i+1 + '.sayi'))
//     i++;
// } while (sayilar[i-1]!=0);
// let toplam=0;
// let sonucDizi = [];
// let cevap = prompt('Tek mi ? - Çift mi ?')

// if (cevap.toLocaleLowerCase() =='Tek') {
//     for (let i = 0; i < sayilar.length; i++) {
//         if (sayilar[i] % 2 ===1 ) {
//             sonucDizi.push(sayilar[i]);
//             toplam+=sayilar[i];
//         }
        
//     }

    
// } else if (cevap.toLocaleLowerCase() =='çift'){

//     for (let i = 0; i < sayilar.length; i++) {
//         if (sayilar[i] % 2 ===0 ) {
//             sonucDizi.push(sayilar[i]);
//             toplam+=sayilar[i];
            
//         }
        
//     }

// }
// else{
//     console.log('doğru cevap verin');
// }

// console.log(sayilar);
// console.log(sonucDizi);
// console.log(toplam);





