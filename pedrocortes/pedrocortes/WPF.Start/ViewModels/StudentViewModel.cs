using Common.Lib.Core;
using Common.Lib.Infrastructure;
using Infraestructure.Commands;
using P.BL.Infraestructure.Interfaces;
using P.BL.Models;
using P.DAL.EFCore;
using P.DAL.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WPF.Start.Infraestructure;

namespace WPF.Start.ViewModels
{
    public class StudentViewModel : GenericViewModel
    {

        #region Propiedades!

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _dni;

        public string Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
                RaisePropertyChanged();
            }
        }

        private string _chair;

        public string Chair
        {
            get
            {
                return _chair;
            }
            set
            {
                _chair = value;
                RaisePropertyChanged();
            }
        }

        private int _stdInDict;

        public int StdInDict
        {
            get 
            { 
                return _stdInDict; 
            }
            set 
            { 
                _stdInDict = value;
                RaisePropertyChanged();
            }
        }

        private string _messageToUser;

        public string MessageToUser
        {
            get 
            { 
                return _messageToUser; 
            }
            set 
            { 
                _messageToUser = value;
                RaisePropertyChanged();
            }
        }



        private Guid _id = default;

        public Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }



        #endregion


        private List<Student> _students = new List<Student>();

        public List<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                RaisePropertyChanged();
            }
        }


        private Student _currentStudent;

        public Student CurrentStudent
        {
            get
            {
                return _currentStudent;
            }
            set
            {
                _currentStudent = value;
                RaisePropertyChanged();
            }
        }


        #region Commands

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                    _saveCommand = new RelayCommand(new Action(Save));

                return _saveCommand;
            }
        }


        private ICommand _getInfoCommand;

        public ICommand GetInfoCommand
        {
            get
            {
                if (_getInfoCommand == null)
                    _getInfoCommand = new RelayCommand(new Action(GetInfo));

                return _getInfoCommand;
            }
        }


        private ICommand _delete;

        public ICommand DeleteCommand
        {
            get
            {
                if (_delete == null)
                    _delete = new RelayCommand(new Action(Delete));

                return _delete;
            }
        }

        private ICommand _editCommand;

        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                    _editCommand = new RelayCommand(new Action(Edit));

                return _editCommand;
            }
        }


        private ICommand _clearCommand;

        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                    _clearCommand = new RelayCommand(new Action(Clear));

                return _clearCommand;
            }
        }

        #endregion

        private void Clear()
        {
            this.Name = null;
            this.Dni = null;
            this.Chair = null;
            this.Id = default;
        }

        private void Edit()
        {
            this.Name = CurrentStudent.Name;
            this.Dni = CurrentStudent.Dni;
            this.Chair = CurrentStudent.Chair.ToString();
            this.Id = CurrentStudent.Id;
        }

        private void Delete()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var stdDelete = repo.Find(CurrentStudent.Id);
            var nomStd = stdDelete.Name;

            if (stdDelete == null)
                MessageToUser = "Este estudiante no se encuentra en la base de datos, seguro que no ha sido ya eliminad@?";

            else
            {
                stdDelete.Delete();
                MessageToUser = $"El estudiante {nomStd} acaba de ser eliminad@!";
            }

            Clear();
            GetInfo();

        }

        private void Save()
        {

            ValidationResult<string> vrName = Student.ValidateName(this.Name);
            ValidationResult<string> vrDni = Student.ValidateDni(this.Dni, Id);
            ValidationResult<int> vrChair = Student.ValidateChair(this.Chair, Id);

            if (vrDni.IsSuccess && vrName.IsSuccess && vrChair.IsSuccess)
            {
                var newStudent = new Student()
                {
                    Name = vrName.ValidatedResult,
                    Dni = vrDni.ValidatedResult,
                    Chair = vrChair.ValidatedResult,
                    Id = this.Id
                };

                var sr = newStudent.Save();

                if (sr.IsSuccess)
                    MessageToUser = $"El estudiante {newStudent.Name} acaba de ser matriculad@! Que pague sus tasas!!";

                Clear();
                GetInfo();

            }
            else
            {
                var errors = string.Empty;
                errors += vrName.AllErrors + "\n\r";
                errors += vrDni.AllErrors + "\n\r";
                errors += vrChair.AllErrors + "\n\r";
                MessageToUser = errors;
            }

        }

        private void GetInfo()
        {
            var repoStu = Entity.DepCon.Resolve<IStudentRepository>();

            if (repoStu.GetNumberStudents() == 0)
            {
                var listaDb = repoStu.QueryAll().ToList();
                foreach (var element in listaDb)
                {
                    repoStu.AddFromDb(element);
                }
            }

            Students = repoStu.QueryAll().ToList();
            StdInDict = repoStu.GetNumberStudents();
        }

    }
}
