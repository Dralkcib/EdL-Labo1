using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labo4.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students = null;
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                if(_students == value)
                {
                    return;
                }
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                if(_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudent");
                }
            }
        }

        private ICommand _editStudentCommand;
        public ICommand EditStudentCommand
        {
            get
            {
                if(_editStudentCommand == null)
                {
                    _editStudentCommand = new RelayCommand(() => EditStudent());
                }
                return _editStudentCommand;
            }
        }

        private INavigationService _navigationService;

        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }

        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }

        private void EditStudent()
        {
            if(CanExecute())
            {
                _navigationService.NavigateTo("SecondPage", SelectedStudent);
            }
        }

        public bool CanExecute()
        {
            return SelectedStudent != null;
        }
    }
}
