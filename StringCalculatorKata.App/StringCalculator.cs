using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.App
{
    public class StringCalculator
    {
        private char[] _delimiters = { ',' };
        
        public int Sum(string delimitedNumbers = "")
        {
            if (string.IsNullOrWhiteSpace(delimitedNumbers))
            {
                // invalid (empty) input string
                return 0;
            }
            else
            {
                string[] listItems = delimitedNumbers.Split(_delimiters);
                int[] _validInts = new int[listItems.Length];
                var validIntValue = 0;
                var validIntCount = 0;

                foreach (var item in listItems)
                {
                    if (int.TryParse(item, out validIntValue))
                    {
                        _validInts[validIntCount] = validIntValue;
                        validIntCount += 1;
                    }
                    else
                    {
                        // invalid (non numeric) input string
                        return 0;
                    }
                }

                // We have a list of Ints
                var sum = 0;
                foreach (var item in _validInts)
                {
                    sum += item;
                }

                return sum;
            }

        }
    }
}
