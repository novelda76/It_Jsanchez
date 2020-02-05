class Home
{   
    constructor()
    {
    }
}

AcademyCrisApp.
    component('home', {
        templateUrl: './js/App/Views/Home/Home.html',
        controller: ('Home', Home),
        controllerAs: 'vm'
    });