using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZhenXu_COMP306_Lab1
{
    public static class ObjectOps
    {

        public static async Task<List<S3Object>> GetObjectList(string bucketName)
        {
            ListObjectsResponse listResponse = await AWSHelper.s3Client.ListObjectsAsync(bucketName);
            return listResponse.S3Objects;        
        }

        public static async Task UploadFileAsync(string filePath, string bucketName)
        {
            try
            {
                var fileTransferUtility = new TransferUtility(AWSHelper.s3Client);

                // Option 1. Upload a file. The file name is used as the object key name.
                await fileTransferUtility.UploadAsync(filePath, bucketName);
               
            }
            catch (AmazonS3Exception e)
            {
                MessageBox.Show("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }

    }
}
