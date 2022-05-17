using System.IO;

namespace ContactsMVC
{
    public static class Settings
    {
        public static int MaxCellphonesCount { get; set; }
        private static string filePath;
        public static string FilePath
        {
            get => filePath;
            set
            {
                filePath = value;

                if(!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
            }
        }
    }
}
