using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightstoneAssessment.Interface;

namespace LightstoneAssessment.Service
{
    public class WordReverser : IWordReverser
    {
        public string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            var words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }

}
