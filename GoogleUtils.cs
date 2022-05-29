using System.IO;
using Microsoft.Extensions.Logging;

namespace Utils.Google
{
    public class GoogleUtils
    {
        public GoogleUtils(ILogger logger)
        {
            this.logger = logger;
        }

        public string imagePath;
        private ILogger logger;

        public void ExtractImage(Stream imageStream)
        {
            logger.LogInformation("Here's the streamed image");
        }
    }
}