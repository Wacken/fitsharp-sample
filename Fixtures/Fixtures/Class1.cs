using fit;
using fitlibrary;

namespace Fixtures
{
    public class SampleDo : ColumnFixture
    {
        private string hi = "2";
        public string Greeting
        {
            get { return hi; }
        }

        public int numerator;
        public int denominator;
  
        public void Numerator(int numerator) {
            this.numerator = numerator;
        }
  
        public void setDenominator(int denominator) {
            this.denominator = denominator;
        }
  
        public int sum() {
            return numerator+denominator;
        }
    }
}