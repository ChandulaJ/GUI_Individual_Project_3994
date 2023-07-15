using DesktopApp.MVVM.ViewModel;
using System.IO;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for DataFormWindow.xaml
    /// </summary>
    public partial class DataFormWindow : Window
    {
       
        /// <summary>
        /// //  private DataFormViewModel dataFormViewModel;
        /// </summary>
        //      private MainViewModel mainViewModel;
        public DataFormWindow()
        {
            InitializeComponent();
            DataContext = new DataFormViewModel();
            ///// this.DataContext = dataFormViewModel;

            //this.mainViewModel = mainViewModel;
            //  this.DataContext = new DataFormViewModel(mainViewModel);
        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        




    }



}
