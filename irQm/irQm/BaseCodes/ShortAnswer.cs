﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class ShortAnswer : IQuestion,IEvaluable
    {
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Answer { get; set; } = new List<string>();
        public List<string> Tags { get; set; } = new List<string>();
        public string UserAnswer { get; set; }
       


        public void Evaluate()
        {
                                                                                  
            for (int i = 0; i < Answer.Count; i++)
            {
                string str = Answer[i];
                if (str.Trim().Replace(" ", "").Replace("‌", "").Replace('ي','ی').Replace( 'ك','ک').Replace('آ', 'ا') == UserAnswer.Replace(" ", "").Replace("‌", "").Replace('ي', 'ی').Replace('ك', 'ک').Replace('آ', 'ا'))
                {
                   
                    gainedScore = Score;
                    break;
                }
               
            }

            
            
        }
    }
}
