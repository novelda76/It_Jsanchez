var AcademyCrisApp = angular.module('AcademyCrisApp',  //CrazyBooksApp nombre del modulo, y el resto son dependencias)
    ['ui.bootstrap',
        'ui.grid',
        'ngRoute']);   

AcademyCrisApp.config(function ($routeProvider, $locationProvider)
{
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
