const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys  ')
let displayValue='0';
function updateDisplay(){
    display.value='displayValue';
}

keys.addEventListener('click',function(event){
    const element=event.target;
    if (!element.matches('button'))  // element buton mu ?
    return;
    
    if (element.classList.contains('operator')) {//gelen eleemnt operator classı içeriyor mu
        console.log('bir operatore tıklandı');
    }

    else if(element.classList.contains('decimal')) {
        console.log('noktaya tıklandı');

    }
    else if(element.classList.contains('clear')) {
        console.log('AC ye tıklandı');

    }
    else{
        console.log('Bir rakama tıklandı.');

    }
    
   
});