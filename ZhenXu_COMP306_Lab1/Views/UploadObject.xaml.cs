using Amazon.S3.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for UploadObject.xaml
    /// </summary>
    public partial class UploadObject : Window
    {
        public UploadObject()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            // hide current window and go back to main window
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            // get the list of bucket and bind it with combo box
            List<S3Bucket> buckets = await BucketOps.GetBucketList();
            cbBuckets.ItemsSource = buckets;
        }

        private async void cbBuckets_DropDownClosed(object sender, EventArgs e)
        {   
            // get selected bucket from combo box
            var selectedBucket = cbBuckets.SelectedItem;
            if (selectedBucket != null)
            {   
                // cast item to S3Bucket only if it is not null
                S3Bucket bucket = selectedBucket as S3Bucket;

                // get the list of objects by bucket name
                List<S3Object> objects = await ObjectOps.GetObjectList(bucket.BucketName);
                // bind it with datagrid view
                objectDataGrid.ItemsSource = objects;
            }
        }

        private void Browse_File(object sender, RoutedEventArgs e)
        {   
            // open a file browser
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {   
                // display file path to textbox
                txtObject.Text = openFileDialog.FileName;
            }
        }

        private async void Upload_Object (object sender, RoutedEventArgs e)
        {   
            // get file path from text box
            String filePath = txtObject.Text;

            var selectedBucket = cbBuckets.SelectedItem;
            if (selectedBucket != null)
            {
                // get bucket from combo box
                S3Bucket bucket = selectedBucket as S3Bucket; 
                String bucketName = bucket.BucketName;

                // upload file 
                await ObjectOps.UploadFileAsync(filePath, bucketName);
                MessageBox.Show("Object uploaded!");
                // reload objects
                List<S3Object> objects = await ObjectOps.GetObjectList(bucketName);
                objectDataGrid.ItemsSource = objects;

            } else
            {
                MessageBox.Show("Please select a bucket!");
            }
         
        }
    }
}
