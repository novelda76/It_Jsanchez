class Subject {

    get Name() {
        return this._name;
    }
    set Name(value) {
        this._name = value;
    }

    get Teacher() {
        return this._teacher;
    }
    set Teacher(value) {
        this._teacher = value;
    }


    constructor($http) {

        this._subjects = [];
        this.Http = $http;
    }

    RequestSubjects() {
        this.Http.get("/api/subjects").then(
            (response) => {
                this.Subjects.length = 0;
                for (let i in response.data) {
                    this.Subjects.push(response.data[i]);
                }
            },
            function errorCallback(response) {
                console.log("POST-ing of data failed");
            }
        );
    }

    AddSubject() {
        var newSubject =
        {
            name: this.Name,
            teacher: this.Teacher,
            
        };


        this.Http.post("/api/Subject", newSubject).then(
            (response) => {
                let sr = response.data;      //response.data conecta con el controller y por lo tanto nos devuelve un SaveResult y sabe que es post por el   this.Http.post
                if (sr.isSuccess === true) {
                    alert("asignatura añadida");

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
    component('subject', {
        templateUrl: './js/App/Views/Index/Home/Subject/Subject.html',
        controller: ('Subject', Subject),
        controllerAs: 'vm'
    });