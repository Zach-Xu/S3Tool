using Amazon.S3;
using Amazon.S3.Model;
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
using System.Windows.Shapes;

namespace ZhenXu_COMP306_Lab1.Views
{
    /// <summary>
    /// Interaction logic for CreateBucket.xaml
    /// </summary>
    /// 
   
    public partial class CreateBucket : Window
    {
        public CreateBucket()
        {
            InitializeComponent();

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {   
            // get the list of buckets and bind it with datagrid
            List<S3Bucket> buckets = await BucketOps.GetBucketList();
            bucketDataGrid.ItemsSource = buckets;
        }

        private void Back_to_Main(object sender, RoutedEventArgs e)
        {   
            // hide current window and go back to main window
            Hide();
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
        }

        private async void Create_Bucket(object sender, RoutedEventArgs e)
        {   
            // get bucket name from textbox
            string bucketName = txtBucketName.Text;
            // create the bucket
            try 
            {  
                // create bucket
                await BucketOps.CreateBucket(bucketName);
                List<S3Bucket> buckets = await BucketOps.GetBucketList();

                // update datagrid view
                bucketDataGrid.ItemsSource = buckets;
                // hide warning if bucket successfully created
                lblWarning.Visibility = Visibility.Hidden;
                MessageBox.Show("Bucket Created!");
            }
            catch (AmazonS3Exception exception)
            {
                Console.WriteLine(exception);
                // display the error and warning
                lblWarning.Visibility = Visibility.Visible;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unknown encountered on server. Message:'{0}' when creating a bucket", exception.Message);
            }

        }
    }
}
