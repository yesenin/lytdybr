using System.Linq;

namespace yesenin.Knuth.Mix
{
    public class Word
    {
        private Sign _sign;
        private Byte[] _bytes = new Byte[5];

        public Word()
        {
            _sign = Sign.Plus;
        }

        public override string ToString()
        {
            var sign = _sign switch
            {
                Sign.Minus => "-",
                _ => "+"
            };

            var bytes = string.Join("|", _bytes.Select(x => x.ToString()));

            return $"{sign}|{bytes}";
        }
    }
}