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

     constructor(name, teacher) {
        this.Name = name;
        this.Teacher = teacher;
       

    }


}