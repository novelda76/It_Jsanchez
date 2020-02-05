class Student {

    get Dni() {
        return this._dni;
    }

    set Dni(value) {
        this._dni = value;
    }

    get Name() {
        return this._name;
    }

    set Name(value) {
        this._name = value;
    }

    get Email() {
        return this._email;
    }

    set Email(value) {
        this._email = value;
    }

    get ChairText() {
        return this._chairText;
    }

    set ChairText(value) {
        this._chairText = value;
    }

    get ChairNumber() {
        return this._chairNumber;
    }

    set ChairNumber(value) {
        this._chairNumber = value;
    }

    get Password() {
        return this._password;
    }

    set Password(value) {
        this._password = value;
    }

    students = []

    constructor($http) {
        this.Http = $http;
    }

    Student() {
        

        var data =
        {
            dni: this.Dni,
            name: this.Name,
            email: this.Email,
            chairText: this.ChairText,
            chairNumber: this.ChairNumber,
            password: this.Password
        };

        this.Http.get("/api/login", data).


        this.Http.post("/api/login", data).
            then((response) => {
                if (response.data === true)
                    Globals.IsLogon = true;
            },
                function errorCallback(response) {
                    console.log("POST-ing of data failed");
                }
            );


    }
}

Student.$inject = ['$http'];

AcademyFinalApp.
    component('student', {
        templateUrl: './js/App/Views/Student/Student.html',
        controller: ('Student', Student),
        controllerAs: 'vm'
    });