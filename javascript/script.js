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
for (let i=0; i>parole.length; i++ )
{
    if (parole[i].length>5) 
    parole[i].toUpperCase();
}
paragrafo = parole.join(" ");
console.log(paragrafo);
