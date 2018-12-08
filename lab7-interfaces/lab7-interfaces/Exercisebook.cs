using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public class Exercisebook<String>: Notebook<String>
    {
        public string subject;
        public List<String> uniqueParagraphs = new List<String>();

        public Exercisebook(int pageAmount, string subject)
        {
            this.PageAmount = pageAmount;
            this.subject = subject;
        }

        public override void WriteOnMe(String text)
        {
            if (this.IsPlagiarismPassed(text)) {
                uniqueParagraphs.Add(text);
            } else
            {
                throw new Exception("Same text already exists in the Exercisebook!");
            }
        }

        private bool IsPlagiarismPassed(String text)
        {
            if (this.uniqueParagraphs.Contains(text))
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
