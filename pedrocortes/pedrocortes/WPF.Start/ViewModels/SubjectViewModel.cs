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
using WPF.Start.ViewModels;

namespace WPF.Start.ViewModels
{
    public class SubjectViewModel : GenericViewModel
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


        private int _sbjInDict;

        public int SbjInDict
        {
            get
            {
                return _sbjInDict;
            }
            set
            {
                _sbjInDict = value;
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

        private List<Subject> _subjects = new List<Subject>();

        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }
            set
            {
                _subjects = value;
                RaisePropertyChanged();
            }
        }


        private Subject _currentSubject;

        public Subject CurrentSubject
        {
            get
            {
                return _currentSubject;
            }
            set
            {
                _currentSubject = value;
                RaisePropertyChanged();
            }
        }


        private List<Teacher> _teachersToSelect;

        public List<Teacher> TeachersToSelect
        {
            get
            {
                return _teachersToSelect;
            }
            set
            {
                _teachersToSelect = value;
                RaisePropertyChanged();
            }
        }


        private Teacher _teacherSelected;

        public Teacher TeacherSelected
        {
            get
            {
                return _teacherSelected;
            }
            set
            {
                _teacherSelected = value;
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
            this.TeacherSelected = null;
            this.Id = default;
        }

        private void GetInfo()
        {
            var repoSub = Entity.DepCon.Resolve<ISubjectRepository>();

            if (repoSub.GetNumberSubjects() == 0)
            {
                var listaDb = repoSub.QueryAll().ToList();
                foreach (var element in listaDb)
                {
                    repoSub.AddFromDb(element);
                }
            }
            Subjects = repoSub.QueryAll().ToList();
            SbjInDict = repoSub.GetNumberSubjects();

            var repoTea = Entity.DepCon.Resolve<ITeacherRepository>();
            TeachersToSelect = repoTea.QueryAll().ToList();

        }

        private void Save()
        {
            ValidationResult<string> vrName = Subject.ValidateName(this.Name);

            if (vrName.IsSuccess && TeacherSelected != null)
            {
                var newSubject = new Subject()
                {
                    Name = vrName.ValidatedResult,
                    Id = this.Id,
                    TeacherName = TeacherSelected.Name

                };

                var sr = newSubject.Save();

                if (sr.IsSuccess)
                    MessageToUser = $"El estudiante {newSubject.Name} acaba de ser matriculad@! Que pague sus tasas!!";

                Clear();
                GetInfo();
            }
        }
    }
}
