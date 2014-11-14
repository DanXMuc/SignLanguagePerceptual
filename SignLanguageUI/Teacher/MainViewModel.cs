using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using Caliburn.Micro;

namespace Teacher
{
    class MainViewModel : PropertyChangedBase {
        private List<SignGesture> _signGestures;

        public List<SignGesture> SignGestures
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
            SignGestures = new List<SignGesture>
            {
                new SignGesture() {Name = "Test1"},
                new SignGesture() {Name = "Test2"},
                new SignGesture() {Name = "Test3"},
                new SignGesture() {Name = "Test4"},
            };

        }

        public void AddGesture()
        {
            MessageBox.Show(string.Format("Add Gesture: {0}", GestureName)); //Don't do this in real life :)
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
