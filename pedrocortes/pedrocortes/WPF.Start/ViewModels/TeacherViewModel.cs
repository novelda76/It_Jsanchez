using Common.Lib.Core;
using Common.Lib.Infrastructure;
using Infraestructure.Commands;
using P.BL.Infraestructure.Interfaces;
using P.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WPF.Start.ViewModels
{
    class TeacherViewModel : GenericViewModel
    {
        #region Properties!

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


        private int _teaInDict;

        public int TeaInDict
        {
            get
            {
                return _teaInDict;
            }
            set
            {
                _teaInDict = value;
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

        #endregion

        private List<Teacher> _teachers = new List<Teacher>();

        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
            set
            {
                _teachers = value;
                RaisePropertyChanged();
            }
        }


        private Teacher _currentTeacher;

        public Teacher CurrentTeacher
        {
            get
            {
                return _currentTeacher;
            }
            set
            {
                _currentTeacher = value;
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

        /*
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
        */

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
            this.Id = default;
        }

        private void GetInfo()
        {
            var repoTea = Entity.DepCon.Resolve<ITeacherRepository>();

            if (repoTea.GetNumberTeachers() == 0)
            {
                var listaDb = repoTea.QueryAll().ToList();
                foreach (var element in listaDb)
                {
                    repoTea.AddFromDb(element);
                }
            }

            Teachers = repoTea.QueryAll().ToList();
            TeaInDict = repoTea.GetNumberTeachers();
        }

        private void Save()
        {
            ValidationResult<string> vrName = Teacher.ValidateName(this.Name);

            if (vrName.IsSuccess)
            {
                var newTeacher = new Teacher()
                {
                    Name = vrName.ValidatedResult,
                    Id = this.Id
                };

                var sr = newTeacher.Save();

                if (sr.IsSuccess)
                    MessageToUser = $"El estudiante {newTeacher.Name} acaba de ser matriculad@! Que pague sus tasas!!";

                Clear();
                GetInfo();
            }

            
        }
    }
}
