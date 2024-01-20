class rectangulo  {
    //constructor de la clase
    constructor(alto, derecho) {
            this.alto = alto;
            this.ancho = ancho;
    }

    //metodo de la clase
    area() {
        console.log(`El area del rectánuglo es ${this.alto * this.ancho}`);
    }
}

//extendes : genera herencia de clases
//super: se puede acceder a las propiedades de la clase base  {en este caso es rectangulo}
class Cuadrado extends rectangulo {
    constructor(lado) {
        
            super(lado, lado);
            this.lado = lado;
        }

        //Metodo de la clase
        area() {
            console.log(`el area del rectangulo es ${this.lado * this.lado}`);
        }

        static MiFuncionEstatica() {
            console.log("Mensaje de clase estatica");
        }

    }

//ejecucion instamsear
const rectangulo1 = new rectangulo(2, 9);
rectangulo.area();

const cuadrado1 = new Cuadrado(4);
cuadrado1.area();

const Figura = new Cuadrado(6);
Figura.area = function () {
    console.log(`El área de la figura es ${this.lado * this.lado}`);
};

Figura.area();

Cuadrado.MiFuncionEstatica();