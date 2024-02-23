using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.Extensions.Configuration;

namespace ZhenXu_COMP306_Lab1
{
    public static class AWSHelper
    {
        public readonly static IAmazonS3 s3Client;

        static AWSHelper()
        {
            s3Client = GetS3Client();
        }

        private static IAmazonS3 GetS3Client()
        {
            return new AmazonS3Client(GetBasicCredentials(), Amazon.RegionEndpoint.CACentral1);
        }

        private static BasicAWSCredentials GetBasicCredentials()
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("AppSettings.json");

            var accessKeyID = builder.Build().GetSection("AWSCredentials").GetSection("AccesskeyID").Value;
            var secretKey = builder.Build().GetSection("AWSCredentials").GetSection("Secretaccesskey").Value;

            return new BasicAWSCredentials(accessKeyID, secretKey);
        }

    }
}
