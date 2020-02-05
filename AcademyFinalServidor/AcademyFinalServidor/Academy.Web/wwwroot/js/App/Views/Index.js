class Index {

    get Students()
    {
        return this._students;
    }

    set Students(value) 
    {
        this._students = value;
    }

    get IsLogon() 
    {
        return Globals.IsLogon;
    }

    constructor($http) {
        this._students = [];
        this.Http = $http;
    }

}
Index.$inject = ['$http'];

AcademyCrisApp.
    component('index', {
        templateUrl: './js/App/Views/Index.html',
        controller: ('Index', Index),
        controllerAs: 'vm'
    });