//resta

function impar (x){
    let impar = 1
    for (let i=1; i<=x; i++){
        if (i%2 == 0){
            impar += i
        }
    }
    return impar
}

console.log(impar(100));