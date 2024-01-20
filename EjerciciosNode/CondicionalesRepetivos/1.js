//sume pares de un rango, mismo ciclo. (1 al 20)

function suma (x){
    let suma = 0
    for (let i=1; i<=x; i++){
        if (i%2 == 0){
            suma += i
        }
    }
    return suma
}

console.log(suma(20));