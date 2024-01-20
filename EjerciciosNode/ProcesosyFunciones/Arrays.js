//capturar 10 valores en un arrelgo y decir cuantos son pares, con expr landa
const arreglo = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//const [Primero, Segundo, Cuarto, Sexto, Octavo, Decimo] = arreglo;
function Par (arreglo) {
    let contador = 0
    let respuesta 
    for (let numero of arreglo) {
        if (numero % 2 == 0) {contador++}
    
    }   
    respuesta = `hay ${contador} pares` 
    return respuesta
}

console.log(Par(arreglo)); 
//console.log("Estos son pares:");

