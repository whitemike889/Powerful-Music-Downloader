using System.ComponentModel;

namespace MusicDownloader
{
    public sealed class DownloadStatus : INotifyPropertyChanged
    {
        private long _Max = long.MaxValue;
        private long _Current = 0L;
        private string _Percent = "0%";
        public long MaxValue
        {
            get => _Max;
            set
            {
                _Max = value;
                _propertyChanged("Max");
            }
        }

        public long CurrentValue
        {
            get => _Current;
            set
            {
                _Current = value;
                _propertyChanged("Current");
            }
        }

        public string DownloadPercent
        {
            get => _Percent;
            set
            {
                _Percent = value;
                _propertyChanged("DownloadPercent");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //{
        //    add
        //    {
        //        PropertyChangedEventHandler propertyChangedEventHandler = _pc;
        //        PropertyChangedEventHandler propertyChangedEventHandler2;
        //        do
        //        {
        //            propertyChangedEventHandler2 = propertyChangedEventHandler;
        //            PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
        //            propertyChangedEventHandler = Interlocked.CompareExchange(ref _pc, value2, propertyChangedEventHandler2);
        //        }
        //        while (propertyChangedEventHandler != propertyChangedEventHandler2);
        //    }
        //    remove
        //    {
        //        PropertyChangedEventHandler propertyChangedEventHandler = _pc;
        //        PropertyChangedEventHandler propertyChangedEventHandler2;
        //        do
        //        {
        //            propertyChangedEventHandler2 = propertyChangedEventHandler;
        //            PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
        //            propertyChangedEventHandler = Interlocked.CompareExchange(ref _pc, value2, propertyChangedEventHandler2);
        //        }
        //        while (propertyChangedEventHandler != propertyChangedEventHandler2);
        //    }
        //}

        private void _propertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
