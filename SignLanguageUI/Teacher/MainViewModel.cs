using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using Caliburn.Micro;

namespace Teacher
{
    class MainViewModel : PropertyChangedBase {
        private BindableCollection<SignGesture> _signGestures;
        private FileSystemWatcher watcher;

        public BindableCollection<SignGesture> SignGestures
        {
            get { return _signGestures; }
            set
            {
                if (Equals(value, _signGestures)) return;
                _signGestures = value;
                NotifyOfPropertyChange(() => SignGestures);
            }
        }

        public string GestureName { get; set; }

        public MainViewModel()
        {
            SignGestures = new BindableCollection<SignGesture>()
            {
                new SignGesture() {Name = "Test1"},
                new SignGesture() {Name = "Test2"},
                new SignGesture() {Name = "Test3"},
                new SignGesture() {Name = "Test4"}
            };

            watcher = new FileSystemWatcher
            {
                Path = @"C:\Gestures",
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                               | NotifyFilters.FileName | NotifyFilters.DirectoryName
            };
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            // Only watch text files.
            //watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Created += (sender, args) =>
            {
                // if a folder was added add to list of gestures
                SignGestures.Add(new SignGesture() { Name=args.Name});
                NotifyOfPropertyChange(() => SignGestures);

                // Specify what is done when a file is changed, created, or deleted.
                //MessageBox.Show("Create File: " + args.Name + " " + args.ChangeType);
            };

            watcher.Deleted += (sender, args) =>
            {
                // if a folder was added add to list of gestures
                SignGesture gestureToDelete = SignGestures.ToList().Find((ge) => ge.Name == args.Name);
                SignGestures.Remove(gestureToDelete);
                NotifyOfPropertyChange(() => SignGestures);

                // Specify what is done when a file is changed, created, or deleted.
                //MessageBox.Show("Delete File: " + args.FullPath + " " + args.ChangeType);
            };

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        public void AddGesture()
        {
            MessageBox.Show(string.Format("Add Gesture: {0}", GestureName)); //Don't do this in real life :)
            SignGestures.Add(new SignGesture() {Name=GestureName});
            NotifyOfPropertyChange(() => SignGestures);
        }

        public void PreviousTake() {
            MessageBox.Show("PreviousTake"); //Don't do this in real life :)
        }

        public void NextTake()
        {
            MessageBox.Show("NextTake"); //Don't do this in real life :)
        }

        public void PlayTake()
        {
            MessageBox.Show("PlayTake"); //Don't do this in real life :)
        }

        public void DeleteTake()
        {
            MessageBox.Show("DeleteTake"); //Don't do this in real life :)
        }

        public void RecordNewTake()
        {
            MessageBox.Show("RecordNewTake"); //Don't do this in real life :)
        }
    }
}
