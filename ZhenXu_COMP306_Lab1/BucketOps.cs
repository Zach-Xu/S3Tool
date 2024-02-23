using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3.Model;

namespace ZhenXu_COMP306_Lab1
{
    public static class BucketOps
    {
        public static async Task CreateBucket(string bucketName)
        {
            var putBucketRequest = new PutBucketRequest
            {
                BucketName = bucketName,
                UseClientRegion = true
            };

            var response = await AWSHelper.s3Client.PutBucketAsync(putBucketRequest);

        }
        public static async Task<List<S3Bucket>> GetBucketList()
        {
            ListBucketsResponse response = await AWSHelper.s3Client.ListBucketsAsync();
            return response.Buckets;
        }
    }
}
