// remarks by the author:
// the property "Value" is the only property using the generic 'T'

public class ConfigurationParameterAPC<T> : // ....
{
	// ...

        private dynamic _Value;
        public dynamic Value
        {
            get { return _Value; }
            set
            {
                if (_Value == value)
                    return;

                if (typeof(T).IsEnum && value is int)
                    _Value = (T)value;
                else
                    _Value = value;

                OnPropertyChanged("Value");
            }
        }
}
