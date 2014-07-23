namespace DgBox
{
    public class File
    {
        public File(string fileName, string localFilePath)
        {
            this.FileName = fileName;
            this.LocalFilePath = localFilePath;
        }
        public string FileName { get; private set; }
        public string LocalFilePath { get; private set; }
    }
}