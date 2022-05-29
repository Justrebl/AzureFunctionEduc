using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Utils.Google;

namespace Exp.BlobFunctions
{
    public class ResizeNewBlobImage
    {
        private GoogleUtils googleUtils;
        [FunctionName("ResizeNewBlobImage")]
        public void Run([BlobTrigger("googleimages/downloaded-images/{name}", Connection = "saexpgoogleimages_STORAGE")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            googleUtils = new GoogleUtils(log);
            googleUtils.ExtractImage(myBlob);
            log.LogInformation($"Here is the path to the newly created image : ");
        }
    }
}
