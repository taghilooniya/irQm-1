using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class Puzzle : IQuestion,IEvaluable
    {
        public string Face { get; set; }
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public List<string> Tags { get ; set; } = new List<string>();
        public Dictionary<string, string> Pairs { get; set; } = new Dictionary<string, string>();
        public List<string> ExtraAnswers { get; set; } = new List<string>();
        public Dictionary<string, string> AnswerPairs { get; set; } = new Dictionary<string, string>();
        public Lesson Lesson { get; set; }

        public void Evaluate()
        {
            var count= AnswerPairs.Count(p=>Pairs.Contains(p));
            gainedScore=Score/count;
            
        }
    }
}
