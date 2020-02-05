
class Student {

    get Name() {
        return this._name;
    }

    set Name(value) {
        this._name = value;
    }


    get Dni() {
        return this._dni;
    }

    set Dni(value) {
        this._dni = value;
    }


    get ChairNumber() {
        return this._chairNumber;
    }

    set ChairNumber(value) {
        this._chairNumber = value;
    }


    get Email() {
        return this._email;
    }

    set Email(value) {
        this._email = value;
    }

    constructor(name, dni, chairNumber, email) {
        this.Name = name;
        this.Dni = dni;
        this.ChairNumber = chairNumber;
        this.Email = email;

    }


}



