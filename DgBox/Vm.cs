namespace DgBox
{
    using System.Collections.ObjectModel;

    public class Vm
    {
        private readonly ObservableCollection<File> files = new ObservableCollection<File>();

        public Vm()
        {
            Files.Add(new File("1", @"C:\XXX"));
            Files.Add(new File("2", @"C:\XXX"));
        }

        public ObservableCollection<File> Files
        {
            get
            {
                return this.files;
            }
        }
    }
}
