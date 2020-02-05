class Register
{
    get Email()
    {
        return this._email;
    }

    set Email(value)
    {
        this._email = value;
    }

    get Password()
    {
        return this._password;
    }

    set Password(value)
    {
        this._password = value;
    }

    constructor($http)
    {
        this.Http = $http;
    }

    Register()
    {
        //alert("user:" + this.Email + " password:" + this.Password);

        var data =
        {
            email: this.Email,
            password: this.Password
        };

        //var data = new LoginDto (this.Email, this.Password);


        this.Http.post("/api/login", data).then(
            (response) =>
            {
                if (response.data === true)
                    Globals.IsLogon = true;
            },
            function errorCallback(response)
            {
                console.log("POST-ing of data failed");
            }
        );


    }
}

Register.$inject = ['$http'];

AcademyCrisApp.
    component('register', {
        templateUrl: './js/App/Views/Start/Register/Register.html',
        controller: ('Register', Register),
        controllerAs: 'vm'
    });