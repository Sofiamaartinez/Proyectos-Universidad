//aprobo y no aprobo
const Num1 = 100;
const Num2 = 70;
const Num3 = 50;
const Num4 = 0;
const Num5 = 80;

//promedio
let resultado = (Num1+Num2+Num3+Num4+Num5)/5

//console.log(`El promedio de las calificaciones ${Num1}, ${Num2}, ${Num3}, ${Num4} y ${Num5} es: ${Num1+Num2+Num3+Num4+Num5/5}`);

if(
    resultado >= 60)
    {
        console.log(`La califiacion de ${resultado} es aprobatoria`);
    }

    else 
    {
        console.log(`La calificacion de ${resultado} es reprobatoria`)
    }