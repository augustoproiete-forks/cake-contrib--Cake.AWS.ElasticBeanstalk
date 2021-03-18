﻿using Amazon;
using Amazon.Runtime;

namespace Cake.AWS.ElasticBeanstalk
{
    /// <summary>
    /// The Elastic Beanstalk settings
    /// </summary>
    public class ElasticBeanstalkSettings
    {
        /// <summary>
        /// The AWS Access Key ID
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// The AWS Secret Access Key.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// The AWS Session Token, if using temporary credentials.
        /// </summary>
        public string SessionToken { get; set; }

        internal AWSCredentials Credentials { get; set; }

        /// <summary>
        /// The endpoints available to AWS clients.
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// Gets or sets the name of the S3 bucket.
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Creates an instance of ElasticBeanstalkSettings
        /// </summary>
        public ElasticBeanstalkSettings()
        {
            Region = RegionEndpoint.USEast1;
        }
    }
}
