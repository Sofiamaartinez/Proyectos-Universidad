class datos  {
    //constructor de la clase
    constructor(num1, num2) {
            this.num1 = num1;
            this.num2 = num2;
    }


}

suma() {
    console.log(`La suma es ${this.num1 * this.num2}`);
}

const suma= new datos(2, 4);
    datos.suma()