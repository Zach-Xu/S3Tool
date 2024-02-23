using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZhenXu_COMP306_Lab1.Views;

namespace ZhenXu_COMP306_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void To_Create_Bucket(object sender, RoutedEventArgs e)
        {
            CreateBucket bucketWin = new CreateBucket();
            // hide current window and display create bucket window
            Hide();
            bucketWin.Show();
        }

        private void To_Upload_Object(object sender, RoutedEventArgs e)
        {
            UploadObject objectWin = new UploadObject();
            // hide current window and display upload object window
            Hide();
            objectWin.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
