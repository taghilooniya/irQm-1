using System;
using System.Collections.Generic;
namespace irQm.BaseCodes
{
    public  class MultiChoices:IQuestion
    {
        public List<Option> Options { get; set; }

        public  string Face { get; set; }
        public string LessonName { get; set; }
        public  float Score { get ; set ; }
        public  float gainedScore { get; set; }
        public float Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}
