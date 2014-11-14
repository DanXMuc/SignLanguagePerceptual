using Caliburn.Micro;

namespace Teacher
{
    class SignGesture : PropertyChangedBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }
    }
}
