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

    get Students()     //Equivale al public List<Student> StudentsList del StudentsViewModel. Por eso en el constructor lo inicializamos con un array vacio (this._students = [];)                
    {
        return this._students;
    }
    set Students(value) {
        this._students = value;
    }



    constructor($http) {

        this._students = [];
        this.Http = $http;
    }

    RequestStudents() {
        this.Http.get("/api/students").then(
            (response) => {
                this.Students.length = 0;
                for (let i in response.data) {
                    this.Students.push(response.data[i]);
                }
            },
            function errorCallback(response) {
                console.log("POST-ing of data failed");
            }
        );
    }

    AddStudent() {
        var newStudent =
        {
            name: this.Name,
            dni: this.Dni,
            chairNumber: this.ChairNumber,
            email: this.Email
        };


        this.Http.post("/api/Student", newStudent).then(
            (response) => {
                let sr = response.data;      //response.data conecta con el controller y por lo tanto nos devuelve un SaveResult y sabe que es post por el   this.Http.post
                if (sr.isSuccess === true) {
                    alert("estudiante añadido");

                }

                //Globals.IsLogon = true;
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
        templateUrl: './js/App/Views/Index/Home/Student/Student.html',
        controller: ('Student', Student),
        controllerAs: 'vm'
    });