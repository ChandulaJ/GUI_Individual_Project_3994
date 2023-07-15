using CommunityToolkit.Mvvm.Input;
using DesktopApp.MVVM.Model;
using DesktopApp.MVVM.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace DesktopApp.MVVM.ViewModel
{


    public partial class DataFormViewModel : StudentDataModel
    {

        String SelectedDept = "";

        // Initaializing placeholder variables

        private string hintIdIn;
        public string HintIdIn
        {
            get { return hintIdIn; }
            set
            {
                if (hintIdIn != value)
                {
                    hintIdIn = value;
                    OnPropertyChanged(nameof(HintIdIn));
                }
            }
        }

        private string hintFirstNameIn;
        public string HintFirstNameIn
        {
            get { return hintFirstNameIn; }
            set
            {
                if (hintFirstNameIn != value)
                {
                    hintFirstNameIn = value;
                    OnPropertyChanged(nameof(HintFirstNameIn));
                }
            }
        }

        private string hintLastNameIn;
        public string HintLastNameIn
        {
            get { return hintLastNameIn; }
            set
            {
                if (hintLastNameIn != value)
                {
                    hintLastNameIn = value;
                    OnPropertyChanged(nameof(HintLastNameIn));
                }
            }
        }

        private string hintDOBIn;
        public string HintDOBIn
        {
            get { return hintDOBIn; }
            set
            {
                if (hintDOBIn != value)
                {
                    hintDOBIn = value;
                    OnPropertyChanged(nameof(HintDOBIn));
                }
            }
        }

        private string hintYearIn;
        public string HintYearIn
        {
            get { return hintYearIn; }
            set
            {
                if (hintYearIn != value)
                {
                    hintYearIn = value;
                    OnPropertyChanged(nameof(HintYearIn));
                }
            }
        }

        private string hintGPAIn;
        public string HintGPAIn
        {
            get { return hintGPAIn; }
            set
            {
                if (hintGPAIn != value)
                {
                    hintGPAIn = value;
                    OnPropertyChanged(nameof(HintGPAIn));
                }
            }
        }

        private string hintPhotoIn;
        public string HintPhotoIn
        {
            get { return hintPhotoIn; }
            set
            {
                if (hintPhotoIn != value)
                {
                    hintPhotoIn = value;
                    OnPropertyChanged(nameof(HintPhotoIn));
                }
            }
        }

       

        // Initializing data variables

        private string _firstName;
        public string FirstNameIn
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstNameIn));
                }
            }
        }


        private string _LastName;
        public string LastNameIn
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    OnPropertyChanged(nameof(LastNameIn));
                }
            }
        }
    
        private string _dob;
        public string DOBIn
        {
            get { return _dob; }
            set
            {
                if (_dob != value)
                {
                    // Validate the input as a date
                    DateTime result;
                    bool isValidDate = DateTime.TryParse(value, out result);

                    if (isValidDate)
                    {
                        _dob = value;
                        OnPropertyChanged(nameof(DOBIn));
                    }
                    else
                    {
                      
                    }
                }
            }
        }




        private string _year;
        public string YearIn
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    // Validate the input as a year
                    int year;
                    bool isValidYear = int.TryParse(value, out year);

                    if (isValidYear && year >= 0)
                    {
                        _year = value;
                        OnPropertyChanged(nameof(YearIn));
                    }
                    else
                    {
                        // Show an error dialog box
                        MessageBox.Show("Invalid year input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }



        private string _gpa;
        public string GPAIn
        {
            get { return _gpa; }
            set
            {
                if (_gpa != value)
                {
                    // Validate the input as a double
                    double result;
                    bool isValidGPA = double.TryParse(value, out result);

                    if (isValidGPA)
                    {
                        _gpa = value;
                        OnPropertyChanged(nameof(GPAIn));
                    }
                    else
                    {
                        // Show an error dialog box
                        MessageBox.Show("Invalid GPA input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private string _id;
        public string IdIn
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    // Validate the input as a id
                    int id;
                    bool isValidId = int.TryParse(value, out id);

                    if (isValidId && id >= 0)
                    {
                        _id = value;
                        OnPropertyChanged(nameof(IdIn));
                    }
                    else
                    {
                        // Show an error dialog box
                        MessageBox.Show("Invalid id input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

       
  

        private string _dept;
        public string DeptIn
        {
            get { return _dept; }
            set
            {
                if (_dept != value)
                {
                    _dept = value;
                    OnPropertyChanged(nameof(DeptIn));
                }
            }
        }


        // Close function for the close button

        private RelayCommand dataFormCloseCommand;

        public ICommand DataFormCloseCommand
        {
            get
            {
                if (dataFormCloseCommand == null)
                {
                    dataFormCloseCommand = new RelayCommand(DataFormClose);
                }

                return dataFormCloseCommand;
            }
        }

        private void DataFormClose()
        {
            Window window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.DataContext == this);
            window.Close();
        }

        // Save function for the save button

        private RelayCommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new RelayCommand(Save);
                }

                return saveCommand;
            }
        }


        private void Save()
        {
           
                string id = IdIn;
                string firstName = FirstNameIn;
                string lastName = LastNameIn;
                string department = SelectedDept;
                string dob = DOBIn;
                string year = YearIn;
                string gpa = GPAIn;
                string imagePath = ImageSource.ToString();

                var mainViewModel = (MainViewModel)Application.Current.MainWindow.DataContext;

                if (mainViewModel.IsEditSelected)
                {
                    mainViewModel.EditExistingStudent(id, firstName, lastName, department, dob, year, gpa, imagePath);
                }
                else
                {
                    mainViewModel.AddNewStudent(id, firstName, lastName, department, dob, year, gpa, imagePath);
                }

                DataFormClose();
        
        }

        

        // Function for select image command
       
        private BitmapImage _imageSource = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
        private readonly OpenFileDialog _openFileDialog;
        public BitmapImage ImageSource
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged(nameof(ImageSource));
                }
            }
        }
        
        public ICommand SelectImageCommand { get; }
        public DataFormViewModel()
        {
            
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            SelectImageCommand = new SelectImageCommand(OnSelectImage, _openFileDialog);
        }

        private void OnSelectImage(object obj)
        {
            string filePath = obj as string;
            BitmapImage bitmap = new BitmapImage(new Uri(filePath));
            ImageSource = bitmap;
        }

        // Department selecting commands

        private RelayCommand elecDeptCommand;
        public ICommand ElecDeptCommand
        {
            get
            {
                if (elecDeptCommand == null)
                {
                    elecDeptCommand = new RelayCommand(SetElecDept);
                }

                return elecDeptCommand;
            }
        }
        private void SetElecDept()
        {
            SelectedDept = "Electrical";

        }

        private RelayCommand marineDeptCommand;
        public ICommand MarineDeptCommand
        {
            get
            {
                if (marineDeptCommand == null)
                {
                    marineDeptCommand = new RelayCommand(SetMarineDept);
                }

                return marineDeptCommand;
            }
        }
        private void SetMarineDept()
        {
            SelectedDept = "Marine";

        }


        private RelayCommand civilDeptCommand;
        public ICommand CivilDeptCommand
        {
            get
            {
                if (civilDeptCommand == null)
                {
                    civilDeptCommand = new RelayCommand(SetCivilDept);
                }

                return civilDeptCommand;
            }
        }
        private void SetCivilDept()
        {
            SelectedDept = "Civil";

        }


        private RelayCommand comDeptCommand;
        public ICommand ComDeptCommand
        {
            get
            {
                if (comDeptCommand == null)
                {
                    comDeptCommand = new RelayCommand(SetComDept);
                }

                return comDeptCommand;
            }
        }
        private void SetComDept()
        {
            SelectedDept = "Computer";

        }

        private RelayCommand mechaDeptCommand;
        public ICommand MechaDeptCommand
        {
            get
            {
                if (mechaDeptCommand == null)
                {
                    mechaDeptCommand = new RelayCommand(SetMechaDept);
                }

                return mechaDeptCommand;
            }
        }
        private void SetMechaDept()
        {
            SelectedDept = "Mechanical";

        }

       
        private bool isElecDept;
        public bool IsElecDept
        {
            get { return isElecDept; }
            set
            {
                if (isElecDept != value)
                {
                    isElecDept = value;
                    OnPropertyChanged("IsElecDept");
                }
            }
        }

        private bool isMechaDept;
        public bool IsMechaDept
        {
            get { return isMechaDept; }
            set
            {
                if (isMechaDept != value)
                {
                    isMechaDept = value;
                    OnPropertyChanged("IsMechaDept");
                }
            }
        }

        private bool isCivilDept;
        public bool IsCivilDept
        {
            get { return isCivilDept; }
            set
            {
                if (isCivilDept != value)
                {
                    isCivilDept = value;
                    OnPropertyChanged("IsCivilDept");
                }
            }
        }

        private bool isComDept;
        public bool IsComDept
        {
            get { return isComDept; }
            set
            {
                if (isComDept != value)
                {
                    isComDept = value;
                    OnPropertyChanged("IsComDept");
                }
            }
        }

        private bool isMarineDept;
        public bool IsMarineDept
        {
            get { return isMarineDept; }
            set
            {
                if (isMarineDept != value)
                {
                    isMarineDept = value;
                    OnPropertyChanged("IsMarineDept");
                }
            }
        }


    }
}      

