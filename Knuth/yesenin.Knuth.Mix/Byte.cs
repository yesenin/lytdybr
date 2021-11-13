using System;

namespace yesenin.Knuth.Mix
{
    public sealed class Byte
    {
        private int _value;
        
        public Byte(int decValue)
        {
            if (decValue < 0 || decValue > 63)
            {
                throw new ArgumentException(nameof(decValue));
            }

            _value = decValue;
        }
        public string DecValue()
        {
            return _value.ToString();
        }
    }
}