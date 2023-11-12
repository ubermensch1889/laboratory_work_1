using System;

namespace _Source.Core
{
    public class ObservableInt : IObservable<int>
    {
        public event Action<int> OnChanged;

        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnChanged?.Invoke(value);
            }
        }

        public ObservableInt()
        {
            Value = 0;
        }
        
        public ObservableInt(int value)
        {
            Value = value;
        }
        
        public IDisposable Subscribe(IObserver<int> observer)
        {
            throw new NotImplementedException();
        }
    }
}