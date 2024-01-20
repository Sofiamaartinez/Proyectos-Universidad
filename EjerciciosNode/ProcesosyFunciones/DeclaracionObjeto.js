let Persona = {
    Nombre: "Juan",
    APaterno: "Perez",
    AMaterno: "Ayala",
    Edad: 40,
    FecNaci: new Date()
}
console.log("El objeto tiene:", Persona)

console.log(`La edad es: ${Persona.Edad} `)

Persona.Edad = "50"

console.log(`La edad es: ${Persona.Edad}`)

const { Nombre, APaterno, Edad } = Persona;

console.log(Nombre);
console.log(APaterno);
console.log(Edad);

// se puede hacerpor medio de funciones

GetDireccion = () => {
    return {
        Calle: "Crystal Vallley",
        Colonia: "Mission de Santa Catarina",
        Municipio: "Santa Catarina",
    };
};

const { Calle, Colonia } = GetDireccion();

console.log(Calle);
console.log(Colonia);

//para arreglos

const arreglo = [1, 2, 3, 4];
const [Primero, Segundo, Cuarto] = arreglo;

console.log("------------");
console.log(Primero);
console.log(Segundo);
console.log(Cuarto);
