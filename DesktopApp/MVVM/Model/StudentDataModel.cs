using CommunityToolkit.Mvvm.Input;
using DesktopApp.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;

namespace DesktopApp.MVVM.Model
{
    public class StudentDataModel : INotifyPropertyChanged
    {
        public bool IsEditSelected { get; set; }
        private static StudentDataModel instance;
        public static StudentDataModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDataModel();
                }
                return instance;
            }
        }

        private ObservableCollection<StudentDataModel> _studentData = new ObservableCollection<StudentDataModel>();
        public ObservableCollection<StudentDataModel> StudentData
        {
            get => _studentData;
            set
            {
                if (_studentData != value)
                {
                    _studentData = value;
                    OnPropertyChanged();
                }
            }
        }
        // Function to add new student
        public void AddNewStudent(string id, string fname, string lname, string dept, string dob, string year, string gpa, string photo)
        {
            var newStudent = new StudentDataModel
            {
                ID = id,
                Fname = fname,
                Lname = lname,
                DOB = dob,
                Dept = dept,
                Year = year,
                GPA = gpa,
                Photo = photo
            };

            StudentData.Add(newStudent);
            OnPropertyChanged(nameof(StudentData));
        }

        // Function to edit existing student
        public void EditExistingStudent(string id, string fname, string lname, string dept, string dob, string year, string gpa, string photo)
        {
            var Studentvalue = StudentData[SelectedIndex];

            if (id ==null) 
            { id = Studentvalue.ID; };

            if (fname == null)
            { fname = Studentvalue.Fname; };

            if (lname == null)
            { lname = Studentvalue.Lname; };

            if (dob == null)
            { dob = Studentvalue.DOB; };

            if (dept == "")
            { dept = Studentvalue.Dept; };

            if (year == null)
            { year = Studentvalue.Year; };

            if (gpa == null)
            { gpa = Studentvalue.GPA; };

            if (photo == null)
            { photo = Studentvalue.Photo; };

            var newStudent = new StudentDataModel
           
            {
                ID =  id,
                Fname = fname,
                Lname = lname,
                DOB = dob,
                Dept = dept,
                Year = year,
                GPA = gpa,
                Photo = photo
            };
            
            
            StudentData.Insert(SelectedIndex,newStudent);
            StudentData.RemoveAt(SelectedIndex);
            OnPropertyChanged(nameof(StudentData));
        }


        private string photo { get; set; }
        private string id { get; set; }
        private string fname { get; set; }
        private string lname { get; set; }
        private string dob { get; set; }
        private string dept { get; set; }
        private string year { get; set; }
        private string gpa { get; set; }


        public string Photo
        {
            get { return photo; }
            set
            {
                if (photo != value)
                {
                    photo = value;
                    OnPropertyChanged(nameof(Photo));
                }
            }
        }
        public string ID
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(ID));
                }
            }
        }
        public string Fname
        {
            get { return fname; }
            set
            {
                if (fname != value)
                {
                    fname = value;
                    OnPropertyChanged(nameof(Fname));
                }
            }
        }

        public string Lname
        {
            get { return lname; }
            set
            {
                if (lname != value)
                {
                    lname = value;
                    OnPropertyChanged(nameof(Lname));
                }
            }
        }
        public string DOB
        {
            get { return dob; }
            set
            {
                if (dob != value)
                {
                    dob = value;
                    OnPropertyChanged(nameof(DOB));
                }
            }
        }
        public string Dept
        {
            get { return dept; }
            set
            {
                if (dept != value)
                {
                    dept = value;
                    OnPropertyChanged(nameof(Dept));
                }
            }
        }

        public string Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    OnPropertyChanged(nameof(Year));
                }
            }
        }

        public string GPA
        {
            get { return gpa; }
            set
            {
                if (gpa != value)
                {
                    gpa = value;
                    OnPropertyChanged(nameof(GPA));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
     
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public ICommand DeleteStudentCommand => new RelayCommand(DeleteStudent);
        private int _selectedIndex = -1;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;

                }
            }
        }

        // Function to delete existing student
        private void DeleteStudent()
        {

            if (SelectedIndex >= 0 && SelectedIndex < StudentData.Count)
            {
                if (StudentData.Any())
                {
                    StudentData.RemoveAt(_selectedIndex);
                    OnPropertyChanged(nameof(StudentData));

                }
            }



        }

    }
}

