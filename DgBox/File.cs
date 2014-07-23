namespace DgBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using DgBox.Annotations;

    public class File : INotifyPropertyChanged
    {
        private bool active;

        public File(string fileName, string localFilePath)
        {
            this.FileName = fileName;
            this.LocalFilePath = localFilePath;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; private set; }

        public string LocalFilePath { get; private set; }

        public bool Active
        {
            get
            {
                return this.active;
            }
            set
            {
                if (value.Equals(this.active))
                {
                    return;
                }
                this.active = value;
                this.OnPropertyChanged();
            }
        }

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