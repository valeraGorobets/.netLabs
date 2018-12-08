using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public class Exercisebook: Notebook<String>
    {
        public const string ExeptionMessage = "Same text already exists in the Exercisebook!";
        public string subject;
        public List<String> uniqueParagraphs = new List<String>();

        public Exercisebook(int pageAmount, string subject)
        {
            this.pageAmount = pageAmount;
            this.subject = subject;
        }

        public override void WriteOnMe(String text)
        {
            if (this.IsPlagiarismPassed(text)) {
                uniqueParagraphs.Add(text);
            } else
            {
                throw new ArgumentException(ExeptionMessage);
            }
        }

        public bool IsPlagiarismPassed(String text)
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
