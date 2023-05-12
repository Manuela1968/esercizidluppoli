// alert('hello world');
console.log('Hello!');

//stampare tabellina 7
let tabellina7 = [];

for(let n = 1 ; n <= 10 ; n++)
{
   // tabellina7[n-1] = 7*n;
   //oppure 
    tabellina7.push(7*n)
    console.log(7*n);
}

   // tabellina7[tabellina7.length] = "end"
   //oppure 
tabellina7.push('END');

for( let n = 7 ; n <= 70 ; n+=7)
{
console.log(n);
}

let paragrafo = "nel meazzo del cammin di nostra vita";
let parole = paragrafo.split(" ");
for (let i=0; i > parole.length; i++ )
{
    if (parole[i].length > 4) 
        parole[i].toUpperCase();
}
paragrafo = parole.join(" ");
console.log(paragrafo);


 
function EvidenziaTesto(paragrafo, numCar=5)
{
    let parole = paragrafo.split(" ");
    for(let i=0; i < parole.length; i++)
    {
        if(parole[i].length > numCar)
        parole[i] = parole[i].toUpperCase();
    }
    return parole.join(" ");
}
let p = "nel meazzo del cammin di nostra vita2";
p = EvidenziaTesto(p, 5);
console.log(p);


function Maiuscoletto(par)
 {
    let parole = par.split(" ");
    for(let i=0; i < parole.length; i++)
    {
        let primalettera = parole[i].charAt(0);
        let parolaRestante = parole[i].slice(1);
        primalettera = primalettera.toUpperCase();
        parole[i] = primalettera + parolaRestante;

        // equivale a: parole[i]= parole[i].charAt(0).toUpperCase() + parole[i].slice(1) ;
    }
    return parole.join(" ");
}
let par = "nel meazzo del cammin di nostra vita3";
par = Maiuscoletto(par);
console.log(par);


function MaiuscoloDoveServe(text)
 {
    let parole = text.split(" ");
    for(let i=1; i < parole.length; i++)
    { // if (i==0) continue; per escludere di togliere la maiuscola dalla prima parola , il che è corretto
        if (parole[i-1].endsWith('.') ||
            parole[i-1].endsWith('?') ||
            parole[i-1].endsWith('!') ) 
            parole[i]= parole[i].charAt(0).toUpperCase() + parole[i].slice(1) ;
        else
            parole[i]= parole[i].charAt(0).toLowerCase() + parole[i].slice(1) ;
    }
    return parole.join(" ");
}
let text = "Nel meazzo Del cammin di nostra vita! mi Ritrovai...4";
text = MaiuscoloDoveServe(text);
console.log(text);

 