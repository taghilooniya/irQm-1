using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class Puzzle : IQuestion, IEvaluable
    {
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Tags { get; set; } = new List<string>();
        public Dictionary<string, string> Pairs { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> AnswerPairs { get; set; } = new Dictionary <string, string>();
        public List<string> ExtraAnswers { get; set; } = new List<string>();
        int count=0;
       
        public void Evaluate()
        {
            foreach (var key in Pairs.Keys)
            {
                if (!Pairs[key].Equals(AnswerPairs[key]))
                {
                    count++;
                }
                gainedScore = Score / count;
            }
        }
    }
}
