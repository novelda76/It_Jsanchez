class Start
{
    IsShowLogin = true;

    constructor()
    {
    }

    ShowLogin()
    {
        this.IsShowLogin = true;
    }

    ShowRegister()
    {
        this.IsShowLogin = false;
    }
}

AcademyCrisApp.
    component('start', {
        templateUrl: './js/App/Views/Start/start.html',
        controller: ('Start', Start),
        controllerAs: 'vm'
    });