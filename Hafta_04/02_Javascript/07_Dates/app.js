let simdi= new Date();
sonuc=simdi;
sonuc=simdi.getDate();//ilgili tarihin gününü yazdık
sonuc=simdi.getDay();//Haftanın kaçıncı günü olduğunu söyledi
sonuc=simdi.getFullYear();//ilgili tarihin yılını söyledi
sonuc=simdi.getHours();//ilgili tarihin saatini verir
sonuc=simdi.getTime();//Tarihin seri numarası


simdi.setFullYear(2015)//SEt komutu ayarlamaya yarar. Yılı değiştirdik
simdi.setMonth(0)// Ayı ocak yaptık.

sonuc=simdi;

let suan=new Date();
sonuc=suan
let kacyilsonra=5;

sonuc=new Date(suan.setFullYear((suan.getFullYear()+kacyilsonra)))//önümüzdeki yılın bugunu yazdık



simdi=new Date();
sonuc=simdi;

let dogumTarihi = new Date(1999,09,28)
sonuc=simdi.getFullYear()-dogumTarihi.getFullYear();//kaç yaşındayım


let milisecond = simdi - dogumTarihi;
let second = milisecond/1000;//kaç sn dir yaşıyom
let minute = second/60; // kaç dk dır yaşıyorum

console.log(dogumTarihi);
console.log(sonuc);