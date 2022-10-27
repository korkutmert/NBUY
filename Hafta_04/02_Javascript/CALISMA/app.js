// let girilen =prompt('Dönüştürmek istediğiniz saniye değerini yazınız. : ')
// let dakika= parseInt(Number(girilen) / 60);
// let saniye=girilen % 60;
// console.log( 'Girdiğiniz değer : ' + dakika + ' ' + ' Dakika ' + saniye + ' saniyedir.');


//----------------------------------------------------------------------------------------

// let girilen=prompt('100 den büyük bir sayı giriniz : ')
// console.log(girilen);
// do {
 
//     if (girilen<=100 && girilen !=='' ) {
//         girilen=prompt('Yanlış girdiniz. 100 den büyük bir sayı giriniz : ')
//     }
    
    
// } while (girilen <=100 && girilen !=='' );

//----------------------------------------------------------------------------------------


// let n = prompt('Bir n değeri giriniz : ')

// let asalMi;
// for (let i = 2; i <= n; i++) 
// {
    
//     asalMi=true;

//     for (let j = 2; j < i; j++) 
//     {
        
        
//         if (i % j === 0)
//         {
//             asalMi=false;
//         }
        
//     }
//     if (asalMi==true) {
//         console.log(i);
        
//     }
// }

//-------------------------------------------------------------------------

let n =prompt('bir sayı giriniz');
nextPrime:
for  (let i = 2; i <= n; i++) 
{
    
    for (let j = 2; j < i; j++) 
    {
        if (i % j === 0) 
        {
            continue nextPrime;//etiketi next prime olan yere git DEDİK.
        }
        
    } 
    console.log(i); 
}

