class Student {

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


    subjects = []

    constructor($http) {
        this.Http = $http;
    }

    Subject() {


        var data =
        {
            name: this.Name,
            teacher: this.Teacher
           
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
    component('subject', {
        templateUrl: './js/App/Views/Subject/Subject.html',
        controller: ('Subject', Subject),
        controllerAs: 'vm'
    });