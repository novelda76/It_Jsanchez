//Aqui es donde vamos a declarar todo lo que necesitemos de angular
var AcademyFinalApp = angular.module('AcademyFinalApp',
    ['ui.bootstrap',
        'ui.grid',
        'ngRoute']);

AcademyFinalApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        /*.when("/", {
            controller: "home",
            controllerAs: "vm",
            templateUrl: "./js/App/Views/Index/Home/Home.html'"
        })*/
        .when("/students", {
            controller: "students",
            controllerAs: "vm",
            templateUrl: "./js/App/Views/Index/Home/Student/Student.html'"

        });

    $locationProvider.html5Mode(true);
})

var Globals = new ClientGlobals();