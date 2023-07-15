using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DesktopApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace DesktopApp.MVVM.ViewModel
{
    public class MainViewModel : StudentDataModel
    {
      
        private DataFormWindow dataFormWindow;
        public string HintIdIn { get; set; }
        public string HintFirstNameIn { get; set; }
        public string HintLastNameIn { get; set; }
        public string HintDOBIn { get; set; }
        public string HintYearIn { get; set; }
        public string HintGPAIn { get; set; }
      


        public MainViewModel()
        {

            
            dataFormWindow = new DataFormWindow();
        
            string imagePath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net7.0-windows", ""), "Images", "1.png");
            string finalimagepath1 = imagePath1.Replace('\\', '/');

            string imagePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net7.0-windows", ""), "Images", "2.png");
            string finalimagepath2 = imagePath2.Replace('\\', '/');

            string imagePath3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net7.0-windows", ""), "Images", "3.png");
            string finalimagepath3 = imagePath3.Replace('\\', '/');


            // Populating with dummy data

            AddNewStudent("5061", "John", "Smith", "Civil", "2/12/1999", "1", "3.63", finalimagepath1);
            AddNewStudent("5062", "Mary", "Johnson", "Mechanical", "3/25/2000", "2", "2.68", finalimagepath3);
            AddNewStudent("5063", "Micheal", "Williams", "Electrical", "5/11/1999", "1", "3.23", finalimagepath2);
            AddNewStudent("5064", "Susan", "Brown", "Marine", "2/24/1998", "3", "3.89", finalimagepath3);
            AddNewStudent("5065", "David", "Johns", "Computer", "12/8/2001", "1", "2.59", finalimagepath1);
            AddNewStudent("5066", "Peter", "Miller", "Civil", "8/05/2001", "4", "3.64", finalimagepath1);
            AddNewStudent("5067", "Laura", "Davis", "Mechanical", "11/13/1998", "2", "3.88", finalimagepath3);
            AddNewStudent("5068", "Sofia", "Lopez", "Electrical", "5/23/1997", "3", "2.63", finalimagepath3);
            AddNewStudent("5069", "William", "Wilson", "Marine", "2/14/2000", "4", "2.89", finalimagepath2);
            AddNewStudent("5070", "Emily", "Anderson", "Computer", "2/12/2002", "4", "3.59", finalimagepath3);
            AddNewStudent("5071", "James", "Moore", "Civil", "11/2/2001", "2", "3.63", finalimagepath1);
            AddNewStudent("5072", "David", "Brown", "Mechanical", "9/5/1999", "2", "3.68", finalimagepath2);
            AddNewStudent("5073", "Peter", "Johnson", "Electrical", "9/7/2001", "1", "2.63", finalimagepath1);
            AddNewStudent("5074", "Jose", "Martin", "Marine", "3/5/1999", "3", "2.49", finalimagepath2);
            AddNewStudent("5075", "Susan", "Miller", "Computer", "9/20/2001", "4", "3.69", finalimagepath3);


        }
      
        // Edit student command

        private RelayCommand editStudentCommand;

        public ICommand EditStudentCommand
        {
            get
            {
                if (editStudentCommand == null)
                {
                    editStudentCommand = new RelayCommand(EditStudent);
                }

                return editStudentCommand;
            }
        }

        private void EditStudent()
        {
            IsEditSelected = true;
            if (SelectedIndex >= 0 && SelectedIndex < StudentData.Count)
            {
                var Studentvalue = StudentData[SelectedIndex];
                DataFormViewModel dataFormViewModel = new DataFormViewModel();

                dataFormViewModel.HintIdIn = Studentvalue.ID;
                dataFormViewModel.HintFirstNameIn = Studentvalue.Fname;
                dataFormViewModel.HintLastNameIn = Studentvalue.Lname;
                dataFormViewModel.HintDOBIn = Studentvalue.DOB;
                dataFormViewModel.HintYearIn = Studentvalue.Year;
                dataFormViewModel.HintGPAIn = Studentvalue.GPA;

                if (Studentvalue.Dept == "Electrical") dataFormViewModel.IsElecDept = true;
                if (Studentvalue.Dept == "Mechanical") dataFormViewModel.IsMechaDept = true;
                if (Studentvalue.Dept == "Computer") dataFormViewModel.IsComDept = true;
                if (Studentvalue.Dept == "Marine") dataFormViewModel.IsMarineDept = true;
                if (Studentvalue.Dept == "Civil") dataFormViewModel.IsCivilDept = true;



                dataFormViewModel.ImageSource = new BitmapImage(new Uri(Studentvalue.Photo, UriKind.Absolute)); ;


                dataFormWindow = new DataFormWindow();
                dataFormWindow.DataContext = dataFormViewModel;
                dataFormWindow.Show();
            }
        }
        // Add student command
        private void AddStudentButton()
        {
            IsEditSelected = false;
            DataFormViewModel dataFormViewModel = new DataFormViewModel();

            dataFormViewModel.HintIdIn = "ID";
            dataFormViewModel.HintFirstNameIn = "First Name";
            dataFormViewModel.HintLastNameIn = "Last Name";
            dataFormViewModel.HintDOBIn = "Date of Birth \"mm/dd/yyyy\"";
            dataFormViewModel.HintYearIn = "Year";
            dataFormViewModel.HintGPAIn = "GPA";

            dataFormWindow = new DataFormWindow();
            dataFormWindow.DataContext = dataFormViewModel;
            dataFormWindow.Show();
          
        }

        private RelayCommand addStudentButtonCommand;

        public ICommand AddStudentButtonCommand
        {
            get
            {
                if (addStudentButtonCommand == null)
                {
                    addStudentButtonCommand = new RelayCommand(AddStudentButton);
                }

                return addStudentButtonCommand;
            }
        }

      

    }
}
