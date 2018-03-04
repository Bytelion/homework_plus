using System;
using System.Collections.Generic;
using System.Text;
 
namespace HomeworkPlus
{
    public class Question
    {
        public string className { get; set; }
        public string question { get; set; }
        public DateTime timeCreated { get; set; }
        
        public Question(string className, string question, DateTime timeCreated)
        {
            this.className = className;
            this.question = question;
            this.timeCreated = timeCreated;
        }
    }
}
