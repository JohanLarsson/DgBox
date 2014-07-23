namespace DgBox
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    using DgBox.Annotations;

    public class Vm : INotifyPropertyChanged
    {
        private readonly ObservableCollection<File> files = new ObservableCollection<File>();

        private string newFile;

        public Vm()
        {
            Files.Add(new File("1", @"C:\XXX"));
            Files.Add(new File("2", @"C:\XXX"));
            AddCommand = new RelayCommand(
                _ => Files.Add(new File(NewFile, @"C:\XXX")),
                _ => !string.IsNullOrEmpty(NewFile));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string NewFile
        {
            get
            {
                return this.newFile;
            }
            set
            {
                if (value == this.newFile)
                {
                    return;
                }
                this.newFile = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<File> Files
        {
            get
            {
                return this.files;
            }
        }

        public ICommand AddCommand { get; private set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
